# .NET 9 + ASP.NET Core MVC AutoMapper Örneği

Bu proje, **.NET 9 + ASP.NET Core MVC** üzerinde **AutoMapper** kullanımını basit bir senaryo ile anlatmaktadır.  

Küçük ama öğretici bir örnek: **User → UserDto dönüşümü**, listeleme ve create işlemleri.  

---

## 🎯 Neden AutoMapper?

Elle property kopyalama yerine AutoMapper kullanmak:

* Kod tekrarını azaltır
* Hata riskini düşürür
* Kodun okunabilirliğini artırır

Tek bir mapping kuralı yazarak nesneden nesneye dönüşümler otomatikleşir.

---

## 📦 Kurulum

1. Projeyi klonlayın veya zip olarak indirin:

```bash
git clone https://github.com/<tektaselvan>/automapper-example.git
cd automapper-example

2. Gerekli NuGet paketini yükleyin:

Install-Package AutoMapper
.NET 9’da AutoMapper Dependency Injection (DI) ile uyumludur; ekstra paket gerekmez.

3. Projeyi çalıştırın:

dotnet run

🗂 Proje Yapısı
automapper-example/
 ├─ Controllers/
 │   └─ UserController.cs
 ├─ DTOs/
 │   └─ UserDto.cs
 ├─ Models/
 │   └─ User.cs
 ├─ Profiles/
 │   └─ UserProfile.cs
 ├─ Views/
 │   └─ User/
 │       ├─ Index.cshtml
 │       └─ Create.cshtml
 └─ Program.cs

🧩 Kullanım
1. Listeleme

/User/Index ile kullanıcı listesini görebilirsiniz.
User entity’leri UserDto’ya AutoMapper ile dönüştürülür.

2. Yeni Kullanıcı

/User/Create ile yeni kullanıcı oluşturabilirsiniz.
DTO → Entity dönüşümü ReverseMap() sayesinde yapılır.

👀 Notlar

DTO’lar sadece View için gerekli alanları içerir; örneğin Password hiç DTO’ya gitmez.

ReverseMap() ile POST işlemleri basitleşir.

Eğer MissingMethodException veya mapping hataları görürsen:

AutoMapper paketinin güncel olduğundan emin ol

Eski AutoMapper.Extensions.Microsoft.DependencyInjection paketini kaldır

builder.Services.AddAutoMapper(typeof(UserProfile)); kaydını kullan

✅ Sonuç

Bu proje ile:

Entity → DTO dönüşümleri otomatikleşir

Kod tekrarları ve hata riski azalır

Kod okunabilirliği ve bakımı artar

POST senaryoları ReverseMap ile kolaylaşır

📌 Kaynaklar

AutoMapper Resmi Sitesi

.NET 9 Documentation
