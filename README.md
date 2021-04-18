# ReCapProject
ÖDEV 7:

Entities, DataAccess, Business ve Console katmanlarını oluşturuldu.
Bir araba(Car) nesnesi oluşturuldu.
Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını eklendi.
InMemory formatta GetById, GetAll, Add, Update, Delete operasyonları yazıldı.
Consolda test edildi.

ÖDEV 8 :

Car nesnesine ek olarak;Brand ve Color nesneleri eklendi.
Sql Server tarafında yeni bir veritabanı kuruldu. Cars,Brands,Colors tablolarını oluşturuldu.
Sisteme Generic IEntityRepository altyapısı yazıldı.
Car, Brand ve Color nesneleri için Entity Framework altyapısı yazıldı.
GetCarsByBrandId , GetCarsByColorId servisleri yazıldı.

ÖDEV 9 :

Core katmanı oluşturuldu.
IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyaları eklendi.
Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getirildi.
Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test edildi. GetAll, GetById, Insert, Update, Delete.

ÖDEV 10:

Core katmanında Results yapılandırması yapıldı.
Kullanıcılar (Users) tablosu oluşturuldu. (Id,FirstName,LastName,Email,Password)
Müşteriler (Cutomers) tablosu oluşturuldu.(UserId,CompanyName)
Arabanın kiralanma (Rentals) bilgisini tutan tablo oluşturuldu.(Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). 
Araba teslim edilmemişse ReturnDate null'dır.)
CRUD operasyonlarını yazıldı.
Yeni müşteriler eklendi.
Arabayı kiralama imkanını kodlandı. (Rental-->Add)

ÖDEV 11:

WebAPI katmanını kuruldu.
Business katmanındaki tüm servislerin Api karşılığını yazıldı.
Postman'de test edildi.

ÖDEV 12:

Autofac desteği eklendi.
FluentValidation desteği eklendi.
AOP desteği eklendi.
ValidationAspect eklendi.
 
 ÖDEV 13:
 
 CarImages (Araba Resimleri) tablosu oluşturuldu.(Id,CarId,ImagePath,Date)
 Api üzerinden arabaya resim ekleyecek sistemi yazıldı.
 Resimler yüklendiği isimle değil, kendi verdiğimiz GUID ile dosyalandırılmıştır.
 Resim silme, güncelleme yetenekleri eklendi.
 Resmin eklendiği tarih sistem tarafından atandı.
 Bir arabaya ait resimleri listeleme imkanı oluşturuldu. (Liste)
 
 
ÖDEV 14:

 JWT entegrasyonu yapıldı.
 
 ÖDEV 15:
 
 Cache, Transaction ve Performance aspectleri eklendi.
 
 
 ve Backend bitti...

 
 



