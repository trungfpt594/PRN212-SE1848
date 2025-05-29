using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;
string ho = "Nguyễn";
string tenlot = "Thị";
string ten = "Tủn";
string full_name = ho + " " + tenlot + " " + ten;
Console.WriteLine(full_name);

StringBuilder sb = new StringBuilder();
sb.AppendLine(ho);
sb.AppendLine("...");
sb.AppendLine(tenlot);
sb.AppendLine("...");
sb.AppendLine(ten);
Console.WriteLine(sb.ToString());
