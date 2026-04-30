# Alpkan System Checker 🚀

Bu proje, C# dili ve .NET SDK kullanılarak geliştirilmiş bir **Donanım İzleme (Hardware Monitor)** aracıdır. Bilgisayarınızdaki CPU ve GPU sensör verilerini anlık olarak terminal üzerinden takip etmenizi sağlar.

## 🛠 Kullanılan Teknolojiler
* **Dil:** C#
* **Platform:** .NET 10.0 (veya 8.0/9.0)
* **Kütüphane:** [LibreHardwareMonitorLib](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor)

## 📋 Özellikler
* **GPU İzleme:** NVIDIA GeForce GTX 1660 SUPER sıcaklık ve Hot Spot verilerini anlık okuma.
* **CPU İzleme:** İşlemci yükü ve sıcaklık takibi.
* **Yönetici Modu:** Sensör verilerine erişim için admin yetkisi ile çalışma desteği.

## ⚠️ Önemli Not
Bazı sistemlerde (Ryzen 5 5600 gibi) işlemci sıcaklığı, Windows sensör kısıtlamaları veya AMD Chipset sürücüsü eksikliği nedeniyle `0°C` olarak görünebilir. Bu durum kod hatası değil, donanım erişim izniyle ilgilidir. Uygulamayı **Yönetici Olarak** çalıştırmak bu sorunu büyük oranda çözer.

## 🚀 Nasıl Çalıştırılır?
1. Bilgisayarınızda .NET SDK yüklü olduğundan emin olun.
2. Terminale `dotnet add package LibreHardwareMonitorLib` yazarak kütüphaneyi kurun.
3. Uygulamayı `dotnet run` komutuyla (Yönetici yetkisiyle) başlatın.

---
**Geliştiren:** Alpkan Ali Yamak - 11. Sınıf Bilişim Bölümü Öğrencisi