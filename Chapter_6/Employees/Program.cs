using System;
using Employees;

Console.WriteLine("**** The Emploee Class Hierarchies");
SalesPerson fred = new SalesPerson
{
    Age = 31,
    Name = "Fred",
    SalesNumber = 50
};

static void CastingExample()
{
    // fred is a manager and is an instance of System.Object
    object fred = new Manager("fre zapata", 34, 657, 78000, "6565 - 898", 4);

    // a manager is an instance of Emploee too
    Employee foso = new Manager("fosoli lolo", 34, 657, 78000, "6565 - 898", 4);

    // a part time sale person is a SalePerson too
    SalesPerson jili = new PtSalesPerson("jilo joli", 34, 657, 78000, "6565 - 898", 4);
}

object[] things = new object[4] ;
things[0] = new Hexagon() ;
things[1] = false ;
things[2] = new Manager() ;
things[3] = "joboli jobol";

foreach (var thing in things)
{   
    // as is used for check casting compatibility
    //قایل تبدیل هست hexagon به thing آیا 
    Hexagon hex = thing as Hexagon;

    if (hex == null)
    {
        Console.WriteLine("this chiz {0} is hexagon", thing);
    }
    else
    {
        Console.WriteLine("this chiz {0} isnt hexagon" , thing);
        hex.Draw();
    }

}
Employee tomy = new Manager();
tomy.Name = "tom mom";
Employee.GivePromotion(tomy);
