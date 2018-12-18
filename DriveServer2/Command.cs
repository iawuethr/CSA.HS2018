using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using RobotCtrl;

namespace DriveServer
{
    [XmlRoot("Commands")]
    class Command
    {
        public const string FilePath = @"\temp\commands.csv";
        public const string headLine = @"Team 11";

        private const float speed = 0.5f;
        private const float acceleration = 0.3f;

        private CommandTypes type = CommandTypes.None;
        private string param1;
        private string param2;

        public Command(CommandTypes type, string param1, string param2)
        {
            this.type = type;
            this.param1 = param1;
            this.param2 = param2;
        }

        public void Drive(Robot robot)
        {
            switch (type)
            {
                case CommandTypes.Line:
                    {
                        robot.Drive.RunLine(float.Parse(param1), speed, acceleration);
                        break;
                    }
                case CommandTypes.TurnLeft:
                    {
                        robot.Drive.RunTurn(-float.Parse(param1), speed, acceleration);
                        break;
                    }
                case CommandTypes.TurnRight:
                    {
                        robot.Drive.RunTurn(float.Parse(param1), speed, acceleration);
                        break;
                    }
                case CommandTypes.ArcLeft:
                    {
                        robot.Drive.RunArcLeft(float.Parse(param1), float.Parse(param2), speed, acceleration);
                        break;
                    }
                case CommandTypes.ArcRight:
                    {
                        robot.Drive.RunArcRight(float.Parse(param1), float.Parse(param2), speed, acceleration);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        public override string ToString()
        {
            return $"{type.ToString()} {param1} {param2}";
        }

        public static List<Command> readCommands()
        {
            List<Command> commandList = new List<Command>();

            createFile();

            using (StreamReader streamReader = new StreamReader(FilePath))
            {
                while (streamReader.Peek() > -1)
                {
                    commandList.Add(ParseCommand(streamReader.ReadLine()));
                }
            }


            return commandList;
        }

        public static Command ParseCommand(string commandLine)
        {
            string[] lineParts = commandLine.Split(' '  );

            CommandTypes trackType = CommandTypes.None;
            string param1 = null;
            string param2 = null;
            try
            {
                trackType = (CommandTypes)Enum.Parse(typeof(CommandTypes), lineParts[0], false);
                param1 = lineParts[1];
                param2 = lineParts[2];
            }
            catch (IndexOutOfRangeException)
            {
                // just leave it empty
            }
            return new Command(trackType, param1, param2);
        }

        public static void newCommand(Command command)
        {
            createFile();

            using (StreamWriter streamWriter = new StreamWriter(FilePath))
            {
                streamWriter.WriteLine(command.ToString());
            }
        }

        public static void createFile()
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }
        }
    }
}
