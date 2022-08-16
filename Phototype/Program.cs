// https://online.visual-paradigm.com/w/pplxtipa/diagrams/#diagram:workspace=pplxtipa&proj=0&id=12
using Prototype;

var admin = new Admin(){RoleId = 2,Password = "123456789",Username = "MyAdmin"};

Console.WriteLine("Admin");

Console.WriteLine(admin);

// ทดสอบ shallow copy ค่าฟิวที่เป็น primary type จะเปลี่ยน แค่ object ที่ assign
var shalowAdmin = admin.ShallowCopy();
shalowAdmin.RoleId = 10;

shalowAdmin.Password = "123";

Console.WriteLine("===========");

Console.WriteLine(nameof(ProvincialField));


// ทดสอบ shallow copy ที่มี property เป็น object  ถ้า assign ค่าให้ฟิว จะเปลี่ยนทั้งสอง object
var pf = new ProvincialField("Trat");

var shallowPf = pf.ShallowCopy() as ProvincialField;

shallowPf.Household.HouseNumber = "1/1";


// ทดสอบ deep copy ที่มี property เป็น object  ถ้า assign ค่าให้ฟิว จะเปลี่ยนแค่ object ที่ถูก assign
var deepCopyPf = pf.DeepCopy() as ProvincialField;

deepCopyPf.Household.HouseNumber = "100/100";


Console.WriteLine("===========");