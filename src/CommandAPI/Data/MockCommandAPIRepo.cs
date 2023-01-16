
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command
                {
                    Id = 0,
                    HowTo = "How to Generate a Migration",
                    CommandLine = "dot net mgr",
                    Platform = ".NET Core EF"
                },
                new Command
                {
                    Id = 1,
                    HowTo = "Run Migrations",
                    CommandLine = "dot net run mgr",
                    Platform = ".NET Core EF"
                },
                new Command
                {
                    Id = 0,
                    HowTo = "List active migrations",
                    CommandLine = "dot net list mgrs",
                    Platform = ".NET Core EF"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                HowTo = "How to Generate a Migration",
                CommandLine = "dot net mgr",
                Platform = ".NET Core EF"
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}