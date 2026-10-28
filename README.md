# The Last Report 📜🔍

**The Last Report** adalah proyek game 2D *Historical Mystery Otome Visual Novel* yang berlatar di Hindia Belanda pada awal abad ke-19. Pemain berperan sebagai staf administrasi yang membantu Gubernur Jenderal Herman Willem Daendels memecahkan teka-teki manipulasi dokumen, dengan mekanik utama *Document & Evidence Investigation* serta *Trust & Relationship System*.

Proyek ini dikembangkan untuk platform PC/Laptop menggunakan **Unity Engine** dengan *template* **Universal 2D**.

## 👥 Tim Pengembang
*   Amanda Puspitarina
*   Marselia Yura Alinski
*   Gina Roselia
*   Rakha Aqilatha Farid
*   Nadia Jasmine Aulia
*   Najwa Azahra Putri

---

## ⚙️ Persyaratan Sistem & Instalasi (WAJIB DIBACA)

Proyek ini menggunakan file multimedia berukuran besar (BGM, SFX, dan 2D Asset Resolusi Tinggi). Oleh karena itu, kita menggunakan **Git LFS (Large File Storage)**. 

**Ikuti langkah ini secara berurutan saat pertama kali bergabung:**

1. **Instal Git LFS:** Buka terminal/Command Prompt di komputermu dan jalankan:
   ```bash
   git lfs install
(Pastikan muncul notifikasi "Git LFS initialized" SEBELUM melakukan clone).

2. **Clone Repositori:**
   ```bash
   git clone [https://github.com/nadnadmine/The-Last-Report.git](https://github.com/nadnadmine/The-Last-Report.git)
Buka di Unity Hub: Buka Unity Hub, pilih Add -> Add project from disk, dan arahkan ke folder repositori yang baru saja di-clone. Pastikan versi Unity Editor yang digunakan sama persis antar anggota tim.

---

## 🚨 Aturan Kolaborasi Git & GitHub (Mencegah Konflik)
Untuk menghindari file tertimpa atau error saat push/pull, patuhi aturan workflow berikut:

1. **Selalu Pull Sebelum Bekerja:**
Sebelum membuka Unity, pastikan proyekmu up-to-date dengan pekerjaan terbaru dari tim.
   ```bash
   git pull origin main 
   ```

2. **Gunakan Branching (Cabang):** JANGAN bekerja langsung di cabang main. Buat cabang baru sesuai fitur atau tugas yang sedang kamu kerjakan (misal: penataan UI, input audio, atau logika drag & drop).
   ```bash
   git checkout -b nama-fitur-kamu
   ```

3. **Commit Pesan yang Jelas:** Jelaskan apa yang kamu ubah agar rekan tim paham.
   ```bash
   git add .
   git commit -m "feat: menambahkan BGM untuk Night Section"
   ```

4. **Merge Melalui Pull Request (PR):** Setelah selesai, push cabangmu ke GitHub dan buat Pull Request. Beri tahu tim di grup untuk melakukan review sebelum di-merge ke main.

---

## 🛠️ Aturan Khusus Proyek Unity
Unity memiliki struktur file yang sensitif. Perhatikan tiga aturan emas berikut:

1. **Aturan File .meta:**
Setiap kali kamu menambahkan aset (gambar, audio, script) ke dalam Unity, Unity akan membuat file .meta. File .meta WAJIB di-commit dan di-push. Jangan pernah menghapusnya dari Git, karena akan merusak referensi di Scene rekan tim.

2. **Jangan Mengedit Scene yang Sama Bersamaan:**
File Scene (.unity) sangat rentan terhadap merge conflict yang sulit diperbaiki. Jika satu orang sedang mengedit Scene "Ruang Kerja Siang", anggota lain JANGAN mengedit Scene yang sama. Koordinasikan pembagian tugas Scene di grup.

3. **Gunakan Prefabs:**
Jika kamu sedang merancang UI (misal: Document Inspection UI) atau objek (misal: Meja Kerja), jadikan objek tersebut sebagai Prefab. Dengan begitu, orang lain bisa mengedit Prefab tersebut tanpa harus membuka dan mengganggu Scene utama.

---

## 📂 Struktur Direktori Aset Utama
Aset proyek akan disimpan dengan rapi di dalam folder Assets/ dengan struktur berikut (mohon sesuaikan jika menyimpan file baru):

* Assets/Audio/ (BGM, SFX Lingkungan, SFX Interaksi)
* Assets/Fonts/ (Font klasik/tulisan tangan)
* Assets/Prefabs/ (UI Dialogue Box, Dokumen, Segel Lilin)
* Assets/Scenes/ (Main Menu, Morning, Midday, Afternoon, Night)
* Assets/Scripts/ (Script C# logika gameplay)
* Assets/Sprites/ (Karakter, Background, Objek Meja, Laporan)

