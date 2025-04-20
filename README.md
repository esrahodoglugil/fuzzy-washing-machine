# FuzzyWashingMachine
# 🧺 Fuzzy Washing Machine (Windows Forms - C#)

Bu proje, **bulanık mantık (fuzzy logic)** ile çalışan bir çamaşır makinesi kontrol sistemini simüle eder. Kullanıcıdan aldığı üç giriş verisine göre deterjan miktarı, yıkama süresi ve dönüş hızı gibi parametreleri hesaplar ve grafiksel olarak görselleştirir.

## 🎯 Amaç

- C# diliyle bulanık mantık sistemini modellemek  
- Mamdani çıkarım sistemi ve ağırlık merkezi (centroid) yöntemi ile durulama yapmak  
- Görsel ve kullanıcı dostu bir Windows Forms arayüzü oluşturmak

---

## ⚙️ Kullanılan Teknolojiler

- .NET Framework (Windows Forms)
- C# (Object-Oriented)
- Fuzzy Logic (Mamdani Tabanlı)
- Grafik çizimi için GDI+ (System.Drawing)

---

## 🔢 Girdiler (Input Variables)

| Girdi       | Kümeler                   | Aralık  |
|-------------|---------------------------|---------|
| Hassaslık   | Sağlam, Orta, Hassas      | 0 - 10  |
| Miktar      | Küçük, Orta, Büyük        | 0 - 10  |
| Kirlilik    | Küçük, Orta, Büyük        | 0 - 10  |

---

## 📤 Çıktılar (Output Variables)

| Çıktı         | Kümeler                                        | Aralık   |
|---------------|------------------------------------------------|----------|
| Deterjan      | Çok Az, Az, Orta, Fazla, Çok Fazla             | 0 - 300  |
| Süre          | Kısa, Normal-Kısa, Orta, Normal-Uzun, Uzun     | 0 - 100  |
| Dönüş Hızı    | Hassas, Normal-Hassas, Orta, Normal-Güçlü, Güçlü | 0 - 10   |

---

## 📐 Kural Tabanı

Sistem 3 giriş değişkeni ve her biri 3 bulanık kümeden oluştuğu için toplamda **27 adet IF-THEN kuralı** içerir. Bu kurallar, çamaşır makinesi kullanımı konusunda uzman kişilerin deneyimleri doğrultusunda hazırlanmıştır.

```txt
Örnek:
IF Hassaslık = Hassas AND Miktar = Küçük AND Kirlilik = Büyük
THEN Dönüş Hızı = Orta AND Süre = Normal-Kısa AND Deterjan = Orta
🧠 Kural İşleme & Çözümleme
Mamdani çıkarım yöntemi

Max–min birleşim

Durulama için centroid (ağırlık merkezi) yöntemi

🖥️ Arayüz (UI Özellikleri)
Girdi değerleri için 3 adet NumericUpDown

Hesaplama butonu

3 adet TextBox ile çıktı gösterimi

PictureBox ile grafik çizimi

Grafik: üyelik fonksiyonları, kesik alanlar ve centroid noktası görsel olarak işaretlenir

📊 Grafiksel Çıktı Örneği

🚀 Başlatma
Bu depoyu indir veya klonla:

bash
Kopyala
Düzenle
git clone https://github.com/esrahodoglugil/FuzzyWashingMachine.git
FuzzyWashingMachine.sln dosyasını Visual Studio ile aç

F5 ile çalıştır

📁 Proje Yapısı
bash
Kopyala
Düzenle
FuzzyWashingMachine/
│
├── Controllers/
│   └── FuzzyEngine.cs       → Tüm inference ve mantık işlemleri
│
├── Models/
│   ├── FuzzySet.cs          → Üyelik fonksiyonları
│   ├── FuzzyRule.cs         → IF–THEN kuralları
│   └── FuzzyVariable.cs     → Giriş / çıkış değişkenleri
│
├── Form1.cs                 → Windows Forms UI mantığı
├── Form1.Designer.cs        → UI bileşenleri
└── Program.cs               → Giriş noktası
📌 Notlar
Girdi aralıkları ve üyelik fonksiyonları doğrudan tahmin edilen gerçek makine özelliklerine dayanmaktadır.

Sistem, farklı giriş kombinasyonlarına göre her seferinde farklı çıktı üretir.

Görselleştirme sayesinde sistemin karar mekanizması şeffaf şekilde incelenebilir.

🧠 Geliştiren
Esra Hodoglugil
📫 GitHub
