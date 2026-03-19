# Satış Programı (Point of Sale Application)

Bu proje satış ve stok yönetimi ile raporlama süreçlerini kolaylaştırmak amacıyla geliştirilmiş bir **C# Windows Forms (Masaüstü)** uygulamasıdır. Entity Framework kullanılarak veritabanı (MSSQL) işlemleri gerçekleştirilmektedir. 

## Özellikler (Features)
- **Kullanıcı Girişi ve Yetkilendirme:** Satış yapma, stok değiştirme, yedekleme veya ayarlar gibi yetkiler atanabilir.
- **Satış Ekranı (Point of Sale):** Hızlı ve pratik bir şekilde satış işlemi yapılabilir.
- **Stok Takibi & Ürün Girişi:** Depodaki ürünlerin sayısını kontrol etme, yeni ürün oluşturma.
- **Raporlama:** Yapılan satışların ve stok durumunun genel raporlanması.
- **Veritabanı Yedekleme:** Uygulama içerisinden kolayca veritabanı yedekleme işlemleri.

## Kurulum (Installation)
1. Projeyi bilgisayarınıza klonlayın.
2. Bilgisayarınızda **Microsoft SQL Server** (veya LocalDB) yüklü olduğundan emin olun.
3. `MarketDB` isimli veritabanını oluşturun veya Entity Framework Migrations/Code First yapısı varsa veritabanının otomatik oluşmasını bekleyin. (Gerekirse Script ile yükleyin.)
4. `SatisDeneme\App.config` içerisindeki connectionstring'de yer alan `data source=.;initial catalog=MarketDB;integrated security=True;` kısmındaki `data source` bilgisini kendi sunucu veya LocalDB isminize göre (örn: `(localdb)\MSSQLLocalDB` veya `.\SQLEXPRESS`) değiştirin.
5. Visual Studio üzerinden projeyi derleyip (Build) başlatın.

## Kullanılan Teknolojiler
- C# .NET Framework 4.7.2
- Windows Forms (WinForms)
- Entity Framework 6.x
- MSSQL (Microsoft SQL Server)

## Katkıda Bulunma
Bu projeyi geliştirmek isterseniz `fork` edebilir ve `pull request` gönderebilirsiniz. 
