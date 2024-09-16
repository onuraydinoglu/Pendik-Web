// Bir ürünler listesi oluştrunuz.
// Bir Kategoriler listesi oluşturunuz.


// Bütün ürünleri listeleyen kodu yazınız.
// Bütün kategorileri listeleyen kodu yazınız.

// Kullanıcıdan kategori verilerini alıp listeye ekleyen daha önce kullanıcının girmiş olduğu id değerine ait veri varsa uyarı mesajı yazsın ve listeyi ekran çıktısı olarak isteyen kodu yazınız.

// Ürünlerin fiyat toplamını gösteren kodu yazınız.

// Kullanıcıdan iki değer alalım bu değerler min ve max değerler olsun
// Bu iki değerler arasında stok verilerini getirsin.

// Ürünler listesinde bir isim değişkeni parametresi alarak uyuşanları listelesin.

// ProductDetail(ProductName, ProductPrice, ProductStock, CategoryName)
// Kullanarak ürün detaylarını listesini ekrana yaz.

using StockManagementConsoleUI;

List<Product> products = new List<Product>()
{
    new Product(
        1,
        "Beymen Ceket",
        15000,
        250
        ),

    new Product(
        2,
        "Prada",
        60000,
        10
        ),

    new Product(
        3,
        "Hk vision Drone",
        400000,
        25
        ),

    new Product(
        4,
        "Dyson Süpürge",
        32000,
        200
        ),

    new Product(
        5,
        "Karaca Vazo",
        500,
        1000
        ),

    new Product(
        6,
        "Kütahya Porselen Ayna",
        1500,
        200
        ),

    new Product(
        7,
        "Adidas Futbol topu",
        5000,
        1520
        ),

    new Product(
        8,
        "Delta Yoga Matı",
        2000,
        531
        )
};


List<Category> categories = new List<Category>()
{
    new Category(1, "Elbise", "Elbise Açıklaması"),
    new Category(2, "Elektronik", "Açıklama"),
    new Category(3, "Spor Aletleri", "Spor aletleri Açıklama"),
};


//GetAllProduct();
//GetAllCategories();
AddProductAndGetAll();


void GetAllCategories()
{
    PrintAyirac("Bütün Kategoriler");
    foreach (Category category in categories)
    {
        Console.WriteLine(category);
    }
}

void GetAllProduct()
{
    PrintAyirac("Bütün Ürünler");
    foreach (Product product in products)
    {
        Console.WriteLine(product);
    }
}

void PrintAyirac(string title)
{
    Console.WriteLine(" ");
    Console.WriteLine(title);
    Console.WriteLine("-----------------------------------");
}

void AddProductAndGetAll()
{
    bool isUnique = true;

    PrintAyirac("Ürün ekle ve listele");

    Console.WriteLine("Lütfen ürün Id'sini giriniz.");
    int id = Convert.ToInt32(Console.ReadLine());

    foreach(Product product in products)
    {
        if(product.Id == id)
        {
            isUnique = false;
        }
    }

    if (!isUnique)
    {
        Console.WriteLine($"Id alanı benzersiz olmalı: {id}");
        return;
    }

    Console.WriteLine("Lütfen ürün Adını giriniz.");
    string name = Console.ReadLine();
    Console.WriteLine("Lütfen ürün Fiyatını giriniz.");
    double price = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Lütfen ürün Stok adetini giriniz.");
    double stock = Convert.ToInt32(Console.ReadLine());

    Product createdProduct = new Product(id, name, price, stock);

 

    products.Add(createdProduct);

    foreach (Product product in products)
    {
        Console.WriteLine(product);
    }
}