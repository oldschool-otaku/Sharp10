namespace Sharp10
{
    public static class Tasks
    {
        public static char GetChar(int pos, string line)
        {
            return line[^1] == line[0] ? 'd' : line[1] == line[3] ? 'c' : line[pos];
        }

        public static bool CheckLetters(string fLine, string sLine)
        {
            return fLine[^1] == sLine[0];
        }

        public static string MakeSomeMagic(string line, int task)
        {
            return task switch
            {
                1 => line[1] + "" + line[3],
                2 => line[1] + "" + line[2] + "" + line[3],
                _ => "what the fuck bro"
            };
        }

        public static string DoSomething(string line, int task)
        {
            switch (task)
            {
                //TODO: отвратительный говнокод, изменить когда-нибудь
                case 1:
                    line = line.Replace('в', 'ф');
                    line = line.Replace('и', 'о');
                    line = line.Replace('р', 'к');

                    return line;
                case 2:
                    line = line.Replace('к', 'т');
                    line = line.Replace('у', 'а');
                    line = line.Replace('р', 'н');
                    line = line.Replace('с', 'ц');

                    return line;
                case 3:
                    line = line.Replace('б', 'д');

                    return line;
                case 4:
                    line = line.Replace('к', 'ф');

                    return line;
                
                default:
                    return "хуета";
            }
        }
    }
}