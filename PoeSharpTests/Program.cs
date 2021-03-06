using System;
using POESharp;
using System.IO;

namespace PoeSharpTests {
    class Program {
        static void Main(string[] args) {
            //Arm arm = new Arm(@"F:\Extracted\PathOfExile\3.17.Siege\Metadata\Terrain\Dungeon\Rooms\Unique\exit_2b.arm");
            //Console.WriteLine(arm.name);
            //foreach(string path in Directory.EnumerateFiles(@"E:\Extracted\PathOfExile\3.17.Siege\Metadata\Terrain\", "*.*gr", SearchOption.AllDirectories)) {
            //Console.Write(Path.GetFileName(path));
            //    Graph g = new Graph(path);
            //    Console.WriteLine($"{g.version} {path}");
            //}

            //Smd smd = new Smd(@"E:\Extracted\PathOfExile\3.18.Sentinel\Art\Models\MONSTERS\GoddessOfMalaise\rig_5529a689.smd");
            //Console.WriteLine(smd.Print());

            /*
            int debug = 0;
            string folder = @"E:\Extracted\PathOfExile\3.18.Sentinel\";
            foreach (string path in Directory.EnumerateFiles(folder, "*.smd", SearchOption.AllDirectories)) {
                string relative = path.Substring(folder.Length);
                string meshPath = Path.Combine(relative.Replace(".smd", ".mesh"));
                Console.WriteLine(meshPath);
                debug++; if (debug > 100) break;
            }
            */
            
            foreach(string path in Directory.EnumerateFiles(@"E:\Extracted\PathOfExile\3.18.Sentinel\Art\Models\MONSTERS\", "*.fmt", SearchOption.AllDirectories)) {
                Fmt smd = new Fmt(path);
                if(smd.vertCount > 0) {
                    Console.WriteLine(path);
                    Console.WriteLine(smd.unk);
                    Console.WriteLine(smd.Print());
                }

            }
            
        }

        static void CopyTextures(string sourcefolder, string destfolder) {

        }
    }


}
