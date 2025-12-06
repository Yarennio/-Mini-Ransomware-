# 🔒 Simple Ransomware Simulation (Basit Fidye Yazılımı Simülasyonu)

Bu proje, siber güvenlikte zararlı yazılımların çalışma mantığını anlamak amacıyla geliştirilmiş, **XOR Şifreleme (Encryption)** algoritması kullanan C# tabanlı bir simülasyon aracıdır.

**Amaç:** Dosya sistemi manipülasyonu (File I/O) ve temel kriptografi (Cryptography) prensiplerini uygulamalı olarak öğrenmektir.

---

## ⚠️ YASAL UYARI (DISCLAIMER)
**Bu proje tamamen EĞİTİM AMAÇLIDIR (Educational Purposes Only).**
Araç, yalnızca kullanıcının belirttiği hedef klasör üzerinde çalışır. Gerçek bir zararlı yazılım değildir, simülasyondur. Kötüye kullanım veya veri kaybından geliştirici sorumlu değildir.

---

## 🚀 Özellikler (Key Features)

* **Dizin Tarama (Directory Scanning):** Hedef klasördeki dosyaları tespit eder (`System.IO`).
* **Şifreleme (Encryption):** Dosya içeriğini XOR algoritması ve sabit bir anahtar (Hardcoded Key) ile okunamaz hale getirir.
* **Şifre Çözme (Decryption):** Aynı anahtarı kullanarak işlemi tersine çevirir ve veriyi kurtarır.
* **Uzantı Manipülasyonu (Extension Spoofing):** Şifrelenen dosyaların uzantısını `.locked` olarak değiştirir, çözüldüğünde eski haline (`.txt`) getirir.
* **Kullanıcı Arayüzü (CLI):** Konsol üzerinden interaktif seçim (Şifrele/Çöz) imkanı sunar.

---

## 🛠️ Teknik Yetkinlikler (Technical Stack)

* **Dil:** C# (.NET Core)
* **Kütüphane:** `System.IO` (Dosya Okuma/Yazma)
* **Algoritma:** XOR (Simetrik Şifreleme Mantığı)
* **Hata Yönetimi:** Try-Catch blokları ile dosya erişim hatalarını (Access Violation) yönetme.

---

## 🧠 Öğrenim Çıktıları (Learning Outcomes)

Bu projeyi geliştirirken edindiğim tecrübeler:
1.  **Malware Analizi Temeli:** Bir yazılımın dosya sistemine nasıl müdahale ettiğini kod seviyesinde anladım.
2.  **Simetrik Şifreleme:** XOR işleminin çift yönlü (Reversible) yapısını kavradım.
3.  **Güvenlik Zafiyeti Analizi:** Kod içine gömülen şifrelerin (Hardcoded Keys) tersine mühendislik (Reverse Engineering) ile ne kadar kolay bulunabileceğini deneyimledim.

---

## 💻 Kurulum ve Kullanım (How to Run)

1.  Projeyi bilgisayarınıza indirin (Clone).
2.  Test için masaüstünde içinde `.txt` dosyaları olan bir klasör oluşturun (Örn: `RansomTest`).
3.  Terminali açın ve projeyi çalıştırın:
    ```bash
    dotnet run
    ```
4.  Program sorduğunda test klasörünüzün yolunu (Path) yapıştırın.
5.  İşlem seçin:
    * `[1]` Dosyaları Kilitle (Encrypt)
    * `[2]` Dosyaları Kurtar (Decrypt)

---
*Developed by [Senin Adın] - Cyber Security Enthusiast*