# Cutebes 💖

![Cutebes Gameplay Screenshot]
![cutebes](https://github.com/user-attachments/assets/4bbecff2-e712-4c57-a929-e34261c9eb2e)
**Mainkan langsung lewat link ini :** http://prcllahelga.itch.io/cutebeshttp://prcllahelga.itch.io/cutebes


## Tentang Cutebes

**Cutebes** adalah game *endless runner* 3D minimalis yang dikembangkan dengan Unity Engine dan C#. Pemain ditantang untuk menghindari rintangan kubus yang muncul terus-menerus, bertujuan untuk mendapatkan skor tertinggi. Game ini menawarkan pengalaman visual yang bersih dengan palet warna pastel yang lembut.

---

## 🎮 Fitur Game

* **Gameplay Menghindar Tanpa Akhir:** Hadapi rintangan kubus yang semakin menantang.
* **Estetika Minimalis:** Desain 3D sederhana dengan fokus pada warna pastel.
* **Sistem Skor:** Lacak dan tingkatkan skor terbaik Anda.
* **Kontrol Responsif:** Gerakan pemain yang mulus dan intuitif.
* **Rintangan Prosedural:** Kubus muncul secara dinamis, memastikan setiap putaran berbeda.

---

## 🕹️ Cara Bermain

* **Bergerak:** Gunakan `A/D`.
* **Tujuan:** Hindari semua kubus rintangan. Bertahanlah selama mungkin untuk mengumpulkan skor.
* **Game Over:** Terjadi jika kubus pemain bertabrakan dengan rintangan.

---

## 🛠️ Teknologi

* **Game Engine:** Unity 6.1 (6000.1.7f1)
* **Bahasa:** C#
* **Fitur Unity:** Rigidbody, Collider, UI Canvas, Scripting.

---

## 🚀 Setup Proyek (Untuk Pengembang)

1.  **Clone Repositori:**
    ```bash
    git clone [https://github.com/helgapricilla/Cutebes.git](https://github.com/helgapricilla/Cutebes.git)
    ```
2.  **Buka di Unity:**
    * Gunakan Unity Hub untuk membuka folder proyek yang telah di-clone.
    * Pastikan versi Unity kompatibel dengan proyek ini.
3.  **Jalankan Scene:**
    * Buka Scene utama (`Assets/Scenes/Menu.unity` atau Scene utama Anda).
    * Tekan `Play` untuk menjalankan game.

---

## 💡 Pembelajaran dalam Pengembangan

* **Manajemen Rintangan Efisien:** Mengatasi tantangan *spawning* dan penghapusan rintangan secara tak terbatas, sering kali diselesaikan dengan [Misal: teknik *Object Pooling*].
* **Responsivitas Kontrol:** Memastikan pergerakan pemain terasa lancar dan presisi, umumnya melalui [Misal: implementasi gerakan berbasis fisika di `FixedUpdate()`].
* **Desain UI Sederhana:** Mengintegrasikan elemen UI seperti skor dengan tampilan minimalis.

---
