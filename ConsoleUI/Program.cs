using Business.Apstract;
using Business.Concrete;
using DataAccess.Apstract;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

using Entities.Concrete;

//ProductTest();

static void ProductTest()
{
   
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}


//CategoryTest();

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);

    }
}


ProductManager test1 = new ProductManager(new EfProductDal());

test1.GetAllByCategoryId(2).ForEach(p => Console.WriteLine(p.ProductName));



