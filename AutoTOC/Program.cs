using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;


namespace AutoTOC
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("AutoTOC V1.1 《PDMS单线图目录自动生成工具》\n注意:请将本工具与生成的matc文件放在同一目录下\n");
            Console.Write("请输入起始页码[1]: ");
            
            // 获取起始页码
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                input = "1";
            }
            int.TryParse(input, out var startPage);

            // 读取所有管线号
            var lines = new List<string>();
            using (var sr = File.OpenText("matc"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line.Trim());
                }
            }
            var pipelines = new List<string>();
            for (var i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith("-6"))
                {
                    var pipeline = lines[i].Replace("-6   ", "") + 
                                   lines[i + 1].Replace("-1   ", "");
                    pipelines.Add(pipeline);
                    Trace.WriteLine(pipeline);
                }    
            }

            // 统计重复管线号
            var newPipelines = new Dictionary<string, int>();
            pipelines.ForEach(x =>
            {
                if (newPipelines.ContainsKey(x))
                {
                    newPipelines[x] += 1;
                }
                else
                {
                    newPipelines[x] = 1;
                }
            });

            // 输出文件
            using (var sw = new StreamWriter("TOC.txt"))
            {
                foreach (var pipeline in newPipelines)
                {
                    sw.WriteLine($"{pipeline.Key}\t{pipeline.Value}");
                }
            }

            Console.Write("目录已生成，按任意键退出!");
            Console.ReadKey();
        }
    }
}
