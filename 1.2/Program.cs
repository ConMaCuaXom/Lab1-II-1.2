//Viết chương trình C# nhập vào các thông tin nhân viên (Id, Name, Address, Birthday,
//Salary, Bonus). In ra màn hình các thông tin nhân viên có định dạng và thêm trường
//TotalSalary=Salary+Bonus).


string id, name, address;
DateTime birthday;
int salary, bonus, totalSalary;

Console.Write("ID nhan vien: ");
id = Console.ReadLine();
Console.Write("Ten nhan vien: ");
name = Console.ReadLine();
Console.Write("Dia chi nhan vien: ");
address = Console.ReadLine();
Console.Write("Sinh nhat nhan vien: ");
birthday = Convert.ToDateTime(Console.ReadLine());
Console.Write("Tien luong: ");
salary = Convert.ToInt32(Console.ReadLine());
Console.Write("Tien thuong: ");
bonus = Convert.ToInt32(Console.ReadLine());
totalSalary = salary + bonus;
Console.WriteLine("===================================");

Console.WriteLine("Id nhan vien: " + id);
Console.WriteLine("Ten nhan vien: " + name);
Console.WriteLine("Dia chi nhan vien: " + address);
Console.WriteLine("Sinh nhat nhan vien:{0:dd/MM/yyyy} " , birthday);
Console.WriteLine("Tien luong nhan vien: " + salary);
Console.WriteLine("Tien thuong nhan vien: " + bonus);
Console.WriteLine("Tong luong nhan vien " + totalSalary);


