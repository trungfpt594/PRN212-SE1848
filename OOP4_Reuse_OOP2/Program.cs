using OOP2;
using OOP4_Reuse_OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee fe = new FulltimeEmployee();
fe.Id = 1;
fe.Name = "Putin";
fe.IdCard = "12345";
fe.Birthday = new DateTime(1952, 12, 25);
Console.WriteLine(fe);
Console.WriteLine("=>AGE=" + fe.Tuoi());

//hãy bổ sung thêm 1 extension method trả về là có phải tháng này là tháng sinh nhật của nhân viên của mình hay không .
//Ví dụ trong công ty mình tháng này ai sinh nhật tháng 5 thì sẽ được ăn bánh sinh nhật