using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;

using software_solution.logger;

namespace software_solution.controller
{
    public static class Parser
    {
        static Logger lgr = StaticLoggerType.GetStaticLogger();

        /// <summary>
        /// Splits string parameter by space and creates a List which contains them.
        /// </summary>
        /// <param name="plainText">String, plain text to be splited</param>
        /// <returns>List of strings made of splitted plain text</returns>
        private static List<string> SplitPlainText(string plainText) {
            List<string> PositionsList = plainText.Split(' ').ToList();
            lgr.Info("SPLIT PLAIN TEXT: "+string.Join(" ", PositionsList));

            return PositionsList;
        }

        /// <summary>
        /// Processes each string from List of strings in order to: uppercase, remove
        /// unnessasary spaces between chars and around.
        /// </summary>
        /// <param name="positionsList">Ref to List of string to alter</param>
        private static void ProcessPositions(ref List<string> positionsList) { 
            for (int eachPosition = 0; eachPosition < positionsList.Count(); eachPosition++)
            {
                positionsList[eachPosition] = positionsList[eachPosition].ToUpper().Trim().Replace("-", "");
                lgr.Info("PROCESS POSITIONS: " + positionsList[eachPosition]);
            }
        }

        /// <summary>
        /// Verify whether each char from the string is a valid hex character,
        /// these including 0-9,A-F.
        /// </summary>
        /// <param name="position">String to check whether it is hexadecimal</param>
        /// <returns>Return false if any of chars are not hex's otherwise return true</returns>
        private static bool VerifyHex(string position)
        {
            // regex is overkill, imo. URL's methods seems valid enough
            foreach (char element in position) {
                if (!Uri.IsHexDigit(element)) {
                    lgr.Info("VERIFY HEX: " + position + " IS NOT A HEX SINCE - " + element);
                    return false;
                }
            }
            lgr.Info("VERIFY HEX: " + position + " IS A HEX");
            return true;
        }

        /// <summary>
        /// Takes List of strings which contains all the positions and checks whether either of
        /// listed positions are actual 24 elements long hexadecimal. Using dropflag function
        /// either just drops this particular position or returns false and stops verification
        /// entirely.
        /// </summary>
        /// <param name="positionsList">List of string positions to verify.</param>
        /// <param name="dropflag">Flag which indicates whether to drop position or function</param>
        /// <returns>Bool true if all the posions are verified, and those that aren't fit is dropped
        /// or false if any of the positions is wrong and flag to drop is set to false.</returns>
        private static bool VerifyPositions(ref List<string> positionsList, bool dropflag = true)
        {
            for (int eachPosition = 0; eachPosition < positionsList.Count(); eachPosition++) {
                if (!VerifyHex(positionsList[eachPosition]) || positionsList[eachPosition].Length != 24) {
                    if (dropflag) {
                        lgr.Info($"VERIFY POSITIONS: POSITION[{positionsList[eachPosition]}]:" +
                            $" DROP SINCE HEX OR LENGTH[{positionsList[eachPosition].Length}]");
                        positionsList.Remove(positionsList[eachPosition]);
                    }
                    else {
                        lgr.Info($"VERIFY POSITIONS: POSITION[{positionsList[eachPosition]}]:" +
                            $" STOP SINCE HEX OR LENGTH[{positionsList[eachPosition].Length}]");
                        return false;
                    }
                }
                else
                {
                    lgr.Info($"VERIFY POSITIONS: POSITION[{positionsList[eachPosition]}]: OKAY");
                    continue;
                }
            }
            return true;
        }

        /// <summary>
        /// Parse entire string of plaintext to find all valid positions and add them to list of all valid hexes.
        /// </summary>
        /// <param name="plainText">Plain text to parse</param>
        /// <returns>List of all valid hexes</returns>
        public static List<string> Parse(string plainText)
        {
            var positionsList = SplitPlainText(plainText);
            ProcessPositions(ref positionsList);
            if (!VerifyPositions(ref positionsList)) {
                lgr.Info($"PARSE: FINISH STOPPED: []");
                return new List<string>();
            };
            lgr.Info($"PARSE: FINISH NOT STOPPED: [{string.Join(" ", positionsList)}]");
            return positionsList;
        }
        
    }
}
