using System.IO;
using System.Text;

namespace LackeyCCG.Plugin.Helpers
{
    public class Checksum
    {
        public static int GetCheckSumFromFile(string path)
        {
            try
            {
                using (var fs = File.Open(path, FileMode.Open))
                {
                    using (var reader = new BinaryReader(fs, Encoding.UTF8))
                    {
                        byte c1 = 10;
                        byte c2 = 13;
                        byte TempChar = 0;
                        int cs = 0;
                        do
                        {
                            TempChar = reader.ReadByte();
                            if (TempChar == c1 || TempChar == c2) continue;
                            cs += TempChar > 127 ? TempChar - 256 : TempChar;
                            cs %= 100000000;
                        } while (reader.BaseStream.Position != (reader.BaseStream.Length));
                        cs -= 1;
                        cs %= 100000000;
                        return cs;
                    }
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
