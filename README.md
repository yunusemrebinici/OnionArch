# CarBook Projesi 🚗

CarBook, kullanıcıların araç kiralama işlemleri yapabileceği, araçların detaylarına ulaşabileceği, lokasyona göre fiyatları görüntüleyebileceği ve kiralama işlemlerini kolayca gerçekleştirebileceği kapsamlı bir platformdur. Admin paneli üzerinden araçlar, lokasyonlar, bloglar, referanslar ve diğer içerikler dinamik olarak yönetilebilir. Ayrıca, kullanıcılar araçlarla ilgili yorumlar yapabilir ve bu yorumları inceleyebilirler.

Bu proje, modern web teknolojileri kullanılarak geliştirilmiş olup, yüksek performans, güvenlik ve sürdürülebilirlik hedeflenmiştir.

## ✨ Temel Özellikler

### Web Sitesi (Kullanıcı Paneli)

* **Araç İnceleme:** Kullanıcılar, mevcut araçların özelliklerini, detaylarını ve kiralama ücretlerini kolayca inceleyebilirler.
* **Lokasyona Göre Filtreleme:** Araçları belirli lokasyonlara göre filtreleyerek kiralama seçeneklerini daraltabilirler.
* **Blog Okuma ve Yorumlama:** Yazarlar tarafından eklenen blog yazılarını okuyabilir ve ilgilendikleri gönderilere yorum bırakabilirler.
* **İletişim:** İletişim paneli aracılığıyla platform yöneticilerine mesaj gönderebilirler.
* **Referanslar:** Diğer kullanıcıların araç kiralama deneyimleriyle ilgili referans yorumlarını okuyabilirler.

### Admin Paneli 🚀

* **Kapsamlı Yönetim:** Adminler, araç bilgilerini, lokasyonları, blogları, referansları, servisleri, sosyal medya bağlantılarını ve diğer tüm site içeriklerini tek bir merkezden yönetebilirler.
* **Dinamik CRUD İşlemleri:** Tüm dinamik alanlar için (araçlar, markalar, lokasyonlar, özellikler vb.) Create, Read, Update, Delete (CRUD) işlemleri gerçekleştirilebilir.
* **Site İstatistikleri:** Site performansına ve içeriğine dair çeşitli istatistikleri görüntüleyebilirler.
* **İlişkili Listelemeler:** Markalara ait araçları ve yazarlara ait blogları kolayca listeleyebilirler.

### Güvenlik ve Kimlik Doğrulama 🔒

* **JWT Entegrasyonu:** Login ve Register sayfalarında JSON Web Token (JWT) tabanlı kimlik doğrulama sistemi entegre edilmiştir.
* **Rol Tabanlı Yetkilendirme:** Kullanıcı rollerine (Admin, Normal Kullanıcı vb.) göre belirli sayfalara ve işlevlere erişim kısıtlanmıştır.

## 🛠️ Kullanılan Teknolojiler

* **Backend:**
    * **ASP.NET Core 8.0:** Güçlü ve yüksek performanslı web uygulamaları geliştirmek için kullanılmıştır.
    * **MSSQL (Microsoft SQL Server):** İlişkisel veritabanı yönetim sistemi olarak kullanılmıştır.
    * **Entity Framework Core:** Veritabanı etkileşimleri için Code First yaklaşımıyla ORM (Object-Relational Mapping) aracıdır.
* **Mimari ve Tasarım Desenleri:**
    * **Onion Architecture:** Uygulamanın katmanlı ve bağımlılıklardan arındırılmış yapısı için tercih edilmiştir.
    * **CQRS (Command Query Responsibility Segregation):** Komut ve sorgu operasyonlarını ayırarak ölçeklenebilirlik ve sürdürülebilirliği artırır.
    * **MediatR:** CQRS ve diğer mesajlaşma desenlerini kolaylaştırmak için kullanılmıştır.
* **Güvenlik ve Validasyon:**
    * **JWT (JSON Web Token):** Güvenli API kimlik doğrulaması için kullanılmıştır.
    * **FluentValidation:** Gelişmiş veri doğrulama kuralları için entegre edilmiştir.
* **Gerçek Zamanlı İletişim:**
    * **SignalR:** Canlı veri takibi ve anlık bildirimler gibi gerçek zamanlı iletişim özellikleri için kullanılmıştır.
* **Diğer Özellikler:**
    * **View Components ve Areas:** MVC yapısında bileşen tabanlı geliştirme ve modüler yapılandırma için kullanılmıştır.

## 🚀 Kurulum Adımları

Projeyi yerel geliştirme ortamınızda çalıştırmak için aşağıdaki adımları takip edin:



2.  **Veritabanını Kurun:**
    * SQL Server Management Studio (SSMS) veya başka bir SQL Server aracı kullanarak `CarBook` adında boş bir veritabanı oluşturun.
    * Projenin kök dizininde  bulunan `script.sql` dosyasını (bu, veritabanı şemasını ve başlangıç verilerini içerir) SQL Server'da çalıştırın.

3.  **Bağlantı Dizesini Güncelleyin:**
    * Gerekli Bağlantı Ayarlarını Yapıp Projeyi Default/Index`den ayağı kaldırabilirsiniz.



## 🌄 Görseller

Buraya projenizden ekran görüntüleri ekleyebilirsiniz. Örneğin:

* Web sitesi ana sayfası
* Araç detay sayfası
* Admin paneli dashboard
* Login/Register sayfası

---

