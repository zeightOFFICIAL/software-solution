using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

using software_solution.logger;

namespace software_solution.controller
{
    public class Parser
    {
        private static readonly Logger logger = new LoggerType().GetLogger();

        /// <summary>
        /// Splits string parameter by space and creates a List which contains them.
        /// </summary>
        /// <param name="plainText">String, plain text to be splited</param>
        /// <returns>List of strings made of splitted plain text</returns>
        private static List<string> SplitPlainText(string plainText) {
            List<string> positionsList = plainText.Split(' ').ToList();
            logger.Info($"Split okay, list of positions: [{string.Join(",", positionsList)}]");

            return positionsList;
        }

        /// <summary>
        /// Processes each string from List of strings in order to: uppercase, remove
        /// unnessasary spaces between chars and around.
        /// </summary>
        /// <param name="positionsList">Ref to List of string to alter</param>
        private static void ProcessPositions(ref List<string> positionsList) { 
            for (int eachPosition = 0; eachPosition < positionsList.Count(); eachPosition++)
            {
                positionsList[eachPosition] = positionsList[eachPosition].ToUpper().Trim().Replace("-", "").Replace(" ", "").Replace("\n", "");
                logger.Info($"Processed position: [{positionsList[eachPosition]}]" + $", indexed as: {eachPosition} -> OKAY");
            }
        }

        /// <summary>
        /// Verify whether each char from the string is a valid hex character,
        /// these including 0-9,A-F.
        /// </summary>
        /// <param name="solePosition">String to check whether it is hexadecimal</param>
        /// <returns>Return false if any of chars are not hex's otherwise return true</returns>
        private static bool VerifyHex(string solePosition)
        {
            // regex is overkill, imo. URL's methods seems valid enough
            foreach (char charElement in solePosition) {
                if (!Uri.IsHexDigit(charElement)) {
                    logger.Info("Verifying position: " + solePosition + ", is not a hex since -> " + charElement);
                    return false;
                }
            }
            logger.Info("Verifying position: " + solePosition + ", is a valid hex -> OKAY");

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
            for (int eachPosition = 0; eachPosition < positionsList.Count(); eachPosition++) 
            {
                if (positionsList[eachPosition].Length != 24 || !VerifyHex(positionsList[eachPosition]))
                {
                    if (dropflag) 
                    {
                        logger.Info($"Position: [{positionsList[eachPosition]}]:" +
                            $" drop since hex or length[{positionsList[eachPosition].Length}] not correct");
                        positionsList[eachPosition] = "";
                    }
                    else 
                    {
                        logger.Info($"Position: [{positionsList[eachPosition]}]:" +
                            $" stop since hex or length[{positionsList[eachPosition].Length}] not correct");
                        return false;
                    }
                }
                else
                {
                    logger.Info($"Position: [{positionsList[eachPosition]}], valid position -> OKAY");
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
                logger.Info($"Finish and stopped: [], due to dropflag = false");
                return new List<string>();
            };

            // очень странный костыль связанный с пустыми строками при пробелах и escape seqs,
            // может не работать при очень сложных строках
            positionsList.RemoveAll(s => s == "");

            logger.Info($"Finish not stopped: all positions: [{string.Join(",", positionsList)}] -> OKAY");

            return positionsList;
        }
        
    }
}
