# PLAN.md — The Last Report

> Dokumen rencana kerja dan pembagian tanggung jawab Final Project UAS Pengembangan Aplikasi Permainan.
>
> **Acuan desain:** Game Design Document (GDD) dan Storyboard *The Last Report* pada dokumen `006_008_027_030_045_077_UTSPAP.pdf`.

## 1. Tujuan Proyek

Mengembangkan **The Last Report**, game 2D Historical Mystery Otome Visual Novel untuk PC/Laptop menggunakan Unity. Pemain berperan sebagai asisten administratif yang membantu Herman Willem Daendels memeriksa laporan pemerintahan, membandingkan bukti, mengambil keputusan, dan membangun hubungan melalui pilihan dialog.

Target hasil akhir adalah game yang dapat dimainkan dari awal sampai salah satu ending tanpa alur yang terputus, dengan mekanik utama berikut:

1. **Dialogue System:** menampilkan percakapan dan memungkinkan pemain melanjutkan dialog.
2. **Branching Dialogue:** menyediakan pilihan respons yang dapat mengubah jalannya percakapan dan nilai Trust.
3. **Trust System:** mencatat akumulasi kepercayaan Daendels terhadap protagonis.
4. **Document Investigation:** memungkinkan pemain membuka, membaca, dan membandingkan dokumen serta menemukan petunjuk.
5. **Final Verdict:** memungkinkan pemain menyerahkan laporan yang dianggap valid melalui drag and drop.
6. **Multiple Endings:** menampilkan salah satu dari tiga ending berdasarkan hasil investigasi dan perkembangan Trust.

## 2. Pembagian Anggota dan Penanggung Jawab

**Catatan pemetaan:** urutan enam peran mengikuti urutan nama anggota pada halaman sampul GDD. Apabila pembagian yang telah disepakati kelompok berbeda, nama pemilik tugas dapat disesuaikan tanpa mengubah cakupan tanggung jawab perannya.

| No. | Anggota | NIM | Peran | Fokus tanggung jawab |
|---|---|---|---|---|
| 1 | Amanda Puspitarina | 2410511006 | Lead Writer & Narrative | Naskah cerita, dialog, pilihan, isi dokumen, dan aturan naratif ending. |
| 2 | Najwa Azahra Putri | 2410511008 | Character Artist | Sprite Herman Willem Daendels beserta variasi ekspresi. |
| 3 | Gina Roselia | 2410511027 | Unity Programmer — Core System | Setup teknis Unity, Dialogue System, Branching Dialogue, dan Trust System. |
| 4 | Rakha Aqilatha Farid | 2410511030 | Unity Programmer — Mechanics & UI Integration | Document Investigation, Evidence Comparison, Clue Found, dan Final Verdict. |
| 5 | Nadia Jasmine Aulia | 2410511045 | Asset & Integration Specialist | Pengelolaan aset, integrasi visual/audio, dan perakitan tampilan scene. |
| 6 | Marselia Yura Alinski | 2410511077 | Testing & Quality Control | Pengujian alur, mekanik, pilihan, ending, serta pencatatan dan verifikasi bug. |

---

## 3. Rincian Tugas Setiap Anggota

### 3.1 Amanda Puspitarina — Lead Writer & Narrative

**Tujuan:** memastikan seluruh cerita, dialog, isi dokumen, dan pilihan pemain konsisten dengan GDD serta dapat langsung diimplementasikan ke dalam game.

**Tugas utama:**

- [ ] Menyusun naskah final berdasarkan urutan cerita: **Main Menu/Start Game → Morning → Midday → Afternoon → Night → Ending**.
- [ ] Merapikan narasi pembuka dan dialog pengenalan konflik pada Morning Section, termasuk permintaan Daendels untuk memeriksa laporan proyek jalan pos.
- [ ] Menulis teks tutorial singkat untuk interaksi meja kerja, pembukaan dokumen, dan cara membandingkan informasi.
- [ ] Menyusun dialog dan percakapan pendukung selama Midday Section agar proses investigasi tetap memiliki kesinambungan naratif.
- [ ] Menyusun **2–3 Dialogue Choices** pada momen yang memerlukan keputusan pemain. Setiap opsi harus memiliki karakter respons yang jelas, misalnya netral/profesional, tegas/kritis, atau personal/perhatian.
- [ ] Menentukan konsekuensi naratif setiap pilihan serta perubahan Trust yang perlu diteruskan kepada Unity Programmer — Core System.
- [ ] Menulis dialog konfrontasi pada Afternoon Section, termasuk pertanyaan Daendels mengenai kesimpulan sementara dan respons protagonis.
- [ ] Menyusun dialog Night Section sebelum dan sesudah pemain melakukan Final Verdict.
- [ ] Menulis naskah untuk ketiga ending: **The Report (Professional One)**, **The Confidant (Companion One)**, dan **Stay (Beloved One)**.
- [ ] Menyiapkan isi teks seluruh dokumen yang muncul di investigasi, sekurang-kurangnya Laporan Utama/Laporan A dan B, Surat Referensi, Catatan Pengeluaran, serta Daftar Nama. Isi dokumen harus menyediakan informasi yang dapat dibandingkan oleh pemain.
- [ ] Membuat ringkasan **evidence & answer key**: informasi yang tidak cocok, petunjuk yang ditemukan, alasan suatu laporan dinyatakan valid, dan laporan yang benar untuk Final Verdict.
- [ ] Menyerahkan naskah final dalam format terstruktur dan konsisten agar programmer dapat memasukkannya tanpa menebak urutan dialog atau konsekuensi pilihan.
- [ ] Menginformasikan perubahan naskah kepada programmer dan QA setelah naskah mulai diintegrasikan. Perubahan dialog tidak boleh mengubah ID pilihan, nilai Trust, atau syarat progres tanpa koordinasi.

**Output/deliverables:**

- Naskah dialog lengkap dari awal sampai ending.
- Daftar Dialogue Choices beserta konsekuensi dan perubahan Trust.
- Teks dokumen investigasi.
- Evidence & answer key untuk seluruh puzzle dan Final Verdict.
- Ringkasan kondisi naratif untuk ketiga ending.

**Kriteria selesai:**

- Tidak ada dialog yang terputus, duplikat, atau memiliki tujuan percakapan yang tidak jelas.
- Semua pilihan memiliki tujuan/konsekuensi yang terdokumentasi.
- Informasi pada dokumen saling konsisten dan mendukung jawaban investigasi.
- Tiga ending memiliki teks dan kondisi naratif yang sudah disepakati bersama programmer.

### 3.2 Najwa Azahra Putri — Character Artist

**Tujuan:** menyediakan sprite karakter Daendels yang konsisten secara visual dan dapat digunakan untuk menunjukkan perubahan sikap karakter sepanjang permainan.

**Tugas utama:**

- [ ] Menyelesaikan desain sprite **Herman Willem Daendels** berdasarkan referensi karakter pada GDD dan gaya visual Visual Novel.
- [ ] Membuat lima variasi ekspresi/sprite utama:
  - [ ] **Default:** ekspresi formal dan berwibawa untuk percakapan normal.
  - [ ] **Critical:** ekspresi skeptis/kritis ketika menanggapi kejanggalan laporan.
  - [ ] **Stern:** ekspresi tegas dan serius ketika konflik atau konfrontasi meningkat.
  - [ ] **Pleased:** ekspresi lebih positif, misalnya senyum tipis setelah pemain memberikan respons atau analisis yang disukai.
  - [ ] **Beloved:** ekspresi hangat dan personal untuk momen hubungan dengan Trust tinggi/Beloved Ending.
- [ ] Menjaga konsistensi desain pada seluruh variasi: proporsi tubuh, pakaian, warna, garis gambar, posisi karakter, dan arah pandang.
- [ ] Menyiapkan file sprite dengan latar transparan dan ukuran kanvas yang konsisten agar mudah diimpor ke Unity.
- [ ] Memberi nama file secara konsisten, misalnya `daendels_default`, `daendels_critical`, `daendels_stern`, `daendels_pleased`, dan `daendels_beloved`.
- [ ] Melakukan pengecekan hasil sprite di dalam layout game bersama Asset & Integration Specialist, terutama ukuran, posisi, dan keterbacaan ekspresi.
- [ ] Menunda pengerjaan **Ending CG** sampai alur utama game dan integrasi mekanik selesai. Setelah build utama stabil, siapkan CG sesuai kebutuhan tiga ending apabila waktu pengerjaan memungkinkan.

**Output/deliverables:**

- Lima sprite ekspresi Daendels dalam format gambar transparan.
- File sumber desain yang dapat diedit.
- Ending CG untuk tiga ending sebagai pekerjaan lanjutan setelah game utama selesai/stabil.

**Kriteria selesai:**

- Lima ekspresi utama tersedia dan dapat dibedakan dengan jelas.
- Semua sprite memiliki format, skala, dan penempatan yang konsisten.
- Sprite dapat diimpor dan ditampilkan dengan benar di Unity.
- Ending CG tidak menjadi penghambat penyelesaian mekanik dan alur utama.

**Batas cakupan:** GDD menggunakan perspektif first-person dan tidak mengharuskan protagonis tampil sebagai sprite kompleks. Prioritas character art adalah sprite Daendels.

### 3.3 Gina Roselia — Unity Programmer (Core System)

**Tujuan:** membangun fondasi teknis permainan dan sistem narasi yang menjadi penghubung antara naskah, pilihan pemain, Trust, serta ending.

**Tugas utama:**

- [ ] Menyiapkan project Unity untuk target PC/Laptop, termasuk pengaturan awal project dan struktur kerja scene.
- [ ] Menyiapkan komponen dasar UI/canvas yang dibutuhkan untuk menampilkan dialog dan pilihan pemain.
- [ ] Membuat **Dialogue System** yang dapat:
  - Menampilkan nama speaker dan teks dialog.
  - Melanjutkan teks/dialog melalui klik kiri.
  - Mengatur urutan dialog sesuai naskah.
  - Menampilkan pilihan respons pada titik percabangan.
  - Berpindah ke dialog atau bagian cerita berikutnya setelah pemain memilih opsi.
- [ ] Membuat **Branching Dialogue System** agar pilihan pemain dapat mengarahkan percakapan ke cabang yang sesuai.
- [ ] Membuat **Trust System** untuk menyimpan nilai Trust selama satu playthrough.
- [ ] Menghubungkan pilihan dialog dengan perubahan Trust, termasuk notifikasi perubahan nilai yang dipicu oleh sistem.
- [ ] Menyepakati format data dialog dan pilihan bersama Lead Writer, misalnya ID dialog, speaker, teks, daftar pilihan, perubahan Trust, dan tujuan dialog berikutnya.
- [ ] Membuat pengelolaan progres cerita empat bagian: **Morning, Midday, Afternoon, dan Night**. Perpindahan bagian mengikuti objektif yang sudah diselesaikan, bukan hanya pergantian waktu otomatis tanpa syarat.
- [ ] Menyiapkan fungsi/aturan pemilihan ending berdasarkan hasil investigasi dan nilai Trust sesuai keputusan kelompok.
- [ ] Menghubungkan sistem ending dengan tiga hasil akhir: The Report, The Confidant, dan Stay.
- [ ] Menyediakan cara yang mudah bagi Mechanics Programmer untuk mengirim status investigasi/hasil Final Verdict ke sistem progres dan ending.
- [ ] Menguji alur dialog dari awal hingga akhir menggunakan naskah sementara sebelum seluruh konten final dimasukkan.

**Output/deliverables:**

- Project Unity dan fondasi scene/UI.
- Dialogue System.
- Branching Dialogue System.
- Trust System dan pemicu Trust Notification.
- Pengelolaan progres empat section.
- Logika pemilihan serta pemanggilan tiga ending.
- Dokumentasi singkat cara memasukkan dialog dan menghubungkan pilihan.

**Kriteria selesai:**

- Dialog berjalan sesuai urutan dan dapat dilanjutkan dengan klik kiri.
- Pilihan dialog yang dipilih mengarahkan pemain ke cabang yang benar.
- Nilai Trust berubah sesuai konfigurasi pilihan dan tidak bertambah berulang akibat satu pilihan yang sama.
- Status investigasi dapat diterima oleh sistem progres/ending.
- Pemain dapat mencapai setiap ending melalui kondisi yang telah disepakati.

### 3.4 Rakha Aqilatha Farid — Unity Programmer (Mechanics & UI Integration)

**Tujuan:** mengembangkan mekanik investigasi dokumen dan klimaks Final Verdict, lalu menghubungkannya dengan UI serta sistem progres game.

**Tugas utama:**

- [ ] Membuat interaksi objek pada meja investigasi agar pemain dapat memilih dokumen menggunakan klik kiri.
- [ ] Membuat **Document Inspection UI** dengan area dokumen utama dan area dokumen referensi/inventori sesuai storyboard.
- [ ] Membuat fitur untuk membuka dan menampilkan dokumen dengan ukuran yang mudah dibaca.
- [ ] Menyiapkan mekanisme pemilihan dokumen pendukung dari inventori untuk dibandingkan dengan dokumen utama.
- [ ] Membuat **Evidence Comparison** agar informasi penting pada dua dokumen dapat dipilih/diklik dan dibandingkan, seperti tanggal, lokasi, nominal dana, nama, tanda tangan, atau segel.
- [ ] Menentukan kondisi ketika pasangan informasi yang dibandingkan dianggap sebagai petunjuk yang valid berdasarkan evidence & answer key dari Lead Writer.
- [ ] Mencatat petunjuk yang sudah ditemukan agar satu petunjuk tidak dihitung berulang kali.
- [ ] Membuat **Clue Found Feedback** yang menampilkan notifikasi ketika pemain berhasil menemukan petunjuk. Efek visual/audio dapat dihubungkan dengan Asset & Integration Specialist.
- [ ] Menghubungkan penyelesaian objektif investigasi dengan progres cerita sehingga pemain dapat melanjutkan ke section berikutnya setelah syarat terpenuhi.
- [ ] Membuat UI **Final Verdict** yang menampilkan pilihan laporan yang harus diserahkan.
- [ ] Mengimplementasikan mekanik **drag and drop**: pemain menyeret dokumen pilihan dan melepaskannya pada target Daendels.
- [ ] Memeriksa apakah dokumen yang diserahkan benar atau salah, kemudian mengirim hasilnya ke Core System untuk memengaruhi status investigasi dan ending.
- [ ] Menyediakan feedback untuk hasil benar maupun salah agar pemain memahami respons game.
- [ ] Menguji interaksi dokumen, perbandingan bukti, dan drag-and-drop dengan mouse pada target PC/Laptop.

**Output/deliverables:**

- Interaksi objek/meja investigasi.
- Document Inspection UI.
- Evidence Comparison dan pencatatan petunjuk.
- Clue Found feedback.
- Final Verdict UI dan drag-and-drop.
- Integrasi status investigasi dengan Core System.

**Kriteria selesai:**

- Dokumen dapat dibuka dan ditutup/dikembalikan ke tampilan investigasi dengan benar.
- Pemain dapat memilih dua dokumen dan membandingkan informasi yang relevan.
- Petunjuk yang valid terdeteksi, ditampilkan, dan tidak terhitung ganda.
- Final Verdict dapat menerima drag-and-drop dan membedakan jawaban benar/salah.
- Hasil investigasi diteruskan ke sistem progres dan ending.

### 3.5 Nadia Jasmine Aulia — Asset & Integration Specialist

**Tujuan:** memastikan seluruh aset visual dan audio tersusun rapi serta terintegrasi ke dalam project Unity dengan tampilan yang konsisten.

**Tugas utama:**

- [ ] Menginventarisasi aset yang sudah tersedia dan mencatat aset yang masih berupa placeholder/belum tersedia.
- [ ] Menata folder aset di Unity agar mudah ditemukan dan tidak tercampur dengan script atau file sementara. Penataan mengikuti struktur repository yang sudah ada apabila struktur tersebut telah ditetapkan.
- [ ] Mengimpor dan menata empat background sesuai siklus waktu:
  - [ ] Kantor Administrasi Pagi.
  - [ ] Kantor Administrasi Siang.
  - [ ] Ruang Kerja Sore.
  - [ ] Ruang Kerja Malam.
- [ ] Mengintegrasikan environment objects yang tersedia, seperti meja kerja kayu, peta Hindia Belanda, tumpukan dokumen, pena bulu, tinta, dan wax seal.
- [ ] Mengimpor dokumen investigasi: Laporan Utama/Laporan A dan B, Surat Referensi, Catatan Pengeluaran, serta Daftar Nama.
- [ ] Mengintegrasikan sprite Daendels dari Character Artist dan memastikan pergantian ekspresi dapat dilakukan oleh sistem dialog.
- [ ] Merakit tampilan UI berdasarkan GDD/storyboard, meliputi Dialogue Box, Dialogue Choice Button, Document Inspection UI, Clue Found, Trust Notification, Final Verdict UI, dan Ending Interface.
- [ ] Menyesuaikan ukuran, posisi, anchor, sorting order, dan pengaturan import sprite agar tampilan tidak terpotong atau berubah saat game dijalankan pada resolusi PC/Laptop yang ditargetkan.
- [ ] Menyiapkan transisi visual suasana Morning, Midday, Afternoon, dan Night, terutama perubahan pencahayaan/warna yang sudah ditentukan pada GDD.
- [ ] Mengintegrasikan aset audio yang tersedia sesuai kebutuhan: BGM formal/administratif, BGM investigasi misterius, BGM hangat/personal, serta SFX klik UI, halaman/dokumen, clue found, Trust notification, dan stempel.
- [ ] Memastikan sumber/lisensi aset eksternal dicatat dan aset yang digunakan memang boleh dimasukkan ke dalam project.
- [ ] Berkoordinasi dengan kedua programmer saat prefab/UI/scene siap diintegrasikan. Hindari mengubah komponen atau nama object yang sedang dipakai script tanpa memberi tahu programmer.
- [ ] Menyiapkan placeholder untuk Ending CG selama ilustrasi final belum selesai. Integrasikan CG final setelah alur inti stabil.

**Output/deliverables:**

- Folder aset Unity yang tertata.
- Empat background section dan environment objects yang terintegrasi.
- Dokumen serta sprite Daendels yang siap digunakan.
- UI/prefab dan scene layout yang terakit.
- Integrasi BGM, SFX, dan ambience yang tersedia.
- Daftar aset beserta status dan sumbernya.

**Kriteria selesai:**

- Semua aset yang dibutuhkan untuk alur utama tersedia di scene yang tepat.
- Tidak ada missing reference, sprite salah, UI saling menutupi, atau gambar terpotong pada resolusi target.
- Ekspresi Daendels dapat diganti oleh sistem.
- Audio diputar pada momen yang tepat dan tidak bertumpuk secara tidak sengaja.
- Placeholder ending dapat diganti dengan CG final tanpa merombak alur utama.

### 3.6 Marselia Yura Alinski — Testing & Quality Control

**Tujuan:** memastikan game dapat dimainkan secara utuh dari awal sampai akhir, seluruh mekanik bekerja sesuai rancangan, dan bug ditemukan serta dilaporkan sebelum build final.

**Tugas utama:**

- [ ] Menyusun test checklist berdasarkan GDD dan storyboard sebelum pengujian penuh dimulai.
- [ ] Melakukan **smoke test** setiap build: game dapat dibuka, menu/start berfungsi, scene dapat dimuat, dan pemain dapat memulai permainan.
- [ ] Menguji seluruh alur dari **Morning → Midday → Afternoon → Night → Ending**.
- [ ] Menguji Dialogue System: teks tampil lengkap, speaker benar, klik kiri melanjutkan dialog, dan tidak ada dialog yang terlewat atau macet.
- [ ] Menguji semua Dialogue Choices: pilihan dapat diklik, cabang yang tepat muncul, dan nilai Trust berubah sesuai naskah.
- [ ] Menguji Trust Notification: nilai/perubahan yang ditampilkan sesuai pilihan dan tidak muncul lebih dari sekali untuk satu aksi.
- [ ] Menguji Document Investigation: dokumen dapat dibuka, informasi terbaca, dokumen pendukung dapat dipilih, dan pemain dapat kembali ke tampilan sebelumnya.
- [ ] Menguji Evidence Comparison: pasangan informasi yang benar memicu Clue Found, sedangkan pasangan yang tidak relevan tidak memberikan feedback keberhasilan palsu.
- [ ] Menguji kondisi progres: section tidak dapat dilewati sebelum objektif wajib selesai dan tidak terkunci setelah objektif terpenuhi.
- [ ] Menguji Final Verdict dengan dua skenario minimal: menyerahkan laporan yang benar dan menyerahkan laporan yang salah.
- [ ] Menguji ketiga ending melalui kombinasi kondisi Trust dan hasil investigasi yang telah disepakati.
- [ ] Menguji interaksi berulang/edge cases, seperti klik cepat berulang, membuka dokumen yang sama berkali-kali, memilih opsi, atau melakukan drag-and-drop yang dilepas di luar target.
- [ ] Memeriksa tampilan pada resolusi target PC/Laptop: teks terbaca, tombol dapat diklik, elemen UI tidak keluar layar, dan sprite/background tidak tertutup secara keliru.
- [ ] Memeriksa audio: BGM berganti sesuai suasana, SFX muncul pada event yang tepat, dan volume tidak mengganggu dialog.
- [ ] Mencatat setiap bug dengan langkah reproduksi, hasil aktual, hasil yang diharapkan, tingkat prioritas, serta bukti screenshot/video jika diperlukan.
- [ ] Melakukan regression test setelah bug diperbaiki dan memastikan perbaikan tidak merusak bagian lain.
- [ ] Melakukan final playthrough menggunakan build kandidat final dan menyampaikan daftar bug yang masih tersisa.

**Output/deliverables:**

- Test checklist/test case.
- Bug report dan daftar status perbaikan.
- Regression test result.
- Final QA summary untuk build yang dikumpulkan.

**Format laporan bug yang disarankan:**

| Field | Isi |
|---|---|
| Bug ID | Nomor identifikasi bug, misalnya `BUG-001`. |
| Build/Version | Versi build ketika bug ditemukan. |
| Area | Dialogue, Trust, Investigation, Final Verdict, UI, Audio, atau Ending. |
| Steps to Reproduce | Langkah berurutan untuk memunculkan bug. |
| Expected Result | Hasil yang seharusnya terjadi. |
| Actual Result | Hasil yang benar-benar terjadi. |
| Severity | Critical / Major / Minor. |
| Status | Open / In Progress / Fixed / Retest / Closed. |

**Kriteria selesai:**

- Semua test case utama sudah dijalankan.
- Tidak ada bug Critical yang belum diselesaikan.
- Bug Major yang tersisa sudah diketahui dan disepakati risikonya oleh kelompok.
- Satu playthrough penuh dari awal sampai ending berhasil dilakukan pada build kandidat final.

---

## 4. Alur Kerja dan Dependensi Antaranggota

Pekerjaan dapat berlangsung paralel, tetapi beberapa output harus tersedia sebelum bagian lain dapat diselesaikan.

| Tahap | Pekerjaan | Penanggung jawab utama | Kolaborasi/dependensi | Hasil tahap |
|---|---|---|---|---|
| 1. Finalisasi rancangan | Mengunci urutan cerita, dialog inti, daftar dokumen, petunjuk, jawaban investigasi, dan kondisi ending. | Lead Writer | Core Programmer, Mechanics Programmer, QA | Naskah dan aturan gameplay siap diimplementasikan. |
| 2. Fondasi project | Setup Unity, struktur scene/UI dasar, format data dialog, dan kontrak integrasi sistem. | Core Programmer | Asset Specialist, Mechanics Programmer | Project dapat dijalankan dan sistem dasar siap dikembangkan. |
| 3. Produksi aset | Menyelesaikan lima ekspresi Daendels dan menyiapkan aset visual/audio yang tersedia. | Character Artist, Asset Specialist | Core Programmer untuk kebutuhan format/ukuran | Aset inti siap diimpor. |
| 4. Implementasi sistem | Mengembangkan dialog, branching, Trust, investigasi dokumen, evidence comparison, dan Final Verdict. | Kedua Unity Programmer | Lead Writer untuk data; Asset Specialist untuk UI/aset | Seluruh mekanik inti berjalan menggunakan aset sementara/final. |
| 5. Integrasi konten | Memasukkan dialog, dokumen, background, sprite, UI, dan audio ke dalam game. | Asset Specialist | Semua anggota sesuai aset/sistem masing-masing | Alur game dapat dimainkan dengan konten yang mendekati final. |
| 6. Pengujian end-to-end | Menguji seluruh section, pilihan, petunjuk, jawaban akhir, dan tiga ending. | QA | Semua pemilik fitur untuk memperbaiki bug | Bug list dan build yang telah diuji. |
| 7. Polishing & final build | Memperbaiki bug prioritas, merapikan UI/audio, mengganti placeholder yang sudah siap, dan membuat build final. | Semua anggota; koordinasi QA | Ending CG dikerjakan setelah mekanik/alur utama stabil | Build final siap dikumpulkan. |

### Urutan prioritas pengerjaan

1. **Wajib terlebih dahulu:** alur game dapat berjalan dari Main Menu sampai ending dengan placeholder yang diperlukan.
2. **Wajib berikutnya:** Dialogue, Trust, Document Investigation, Evidence Comparison, dan Final Verdict terintegrasi.
3. **Berikutnya:** seluruh konten dialog/dokumen dan aset utama dimasukkan; semua section dapat dimainkan.
4. **Polishing:** transisi, feedback visual/audio, perapian tampilan, serta variasi sprite.
5. **Pekerjaan lanjutan:** Ending CG untuk masing-masing ending setelah game utama selesai/stabil dan masih tersedia waktu pengerjaan.

---

## 5. Aturan Integrasi dan Kolaborasi

### 5.1 Kontrak antarbagian

Agar pekerjaan tidak saling menunggu atau menghasilkan implementasi yang berbeda, gunakan kesepakatan berikut:

- **Lead Writer → Core Programmer:** menyerahkan naskah dengan urutan dialog, speaker, teks, ID pilihan, konsekuensi pilihan, perubahan Trust, dan tujuan dialog berikutnya.
- **Lead Writer → Mechanics Programmer:** menyerahkan isi dokumen, daftar fakta yang dibandingkan, kondisi petunjuk valid, serta laporan yang benar untuk Final Verdict.
- **Character Artist → Asset Specialist:** menyerahkan sprite transparan dengan ukuran/penamaan konsisten dan daftar ekspresi.
- **Asset Specialist → Programmer:** memberi tahu nama object/prefab, komponen UI, dan event yang tersedia sebelum programmer menghubungkan script.
- **Core Programmer ↔ Mechanics Programmer:** menyepakati cara mengirim status clue, hasil Final Verdict, perubahan section, dan kondisi ending.
- **QA → seluruh pemilik fitur:** melaporkan bug kepada penanggung jawab area terkait dan melakukan retest setelah perbaikan.

### 5.2 Pengelolaan Repository

Gunakan repository kelompok yang sudah dibuat sebagai sumber project utama. Terapkan kebiasaan kerja berikut:

- Sebelum mulai bekerja, lakukan sinkronisasi dengan branch utama dan pastikan perubahan lokal aman.
- Kerjakan fitur pada branch terpisah dengan nama yang menggambarkan tugas, misalnya `feature/dialogue-system`, `feature/document-inspection`, `art/daendels-expressions`, atau `integration/ui-assets`.
- Hindari mengerjakan atau mengubah scene Unity yang sama secara bersamaan. Tentukan satu penanggung jawab untuk layout scene; perubahan dari anggota lain dikoordinasikan terlebih dahulu.
- Jangan mengubah nama GameObject, prefab, event, atau referensi yang sedang dipakai script tanpa memberi tahu programmer terkait.
- Lakukan commit secara berkala dengan pesan yang menjelaskan perubahan.
- Sebelum merge, pastikan perubahan tidak merusak project dan sertakan ringkasan pengujian.
- Pastikan file sementara/cache Unity tidak ikut di-commit. Ikuti `.gitignore` Unity pada repository.
- Jangan menghapus atau menimpa aset/script anggota lain tanpa koordinasi.

### 5.3 Komunikasi Perubahan

Setiap perubahan pada tiga hal berikut wajib diinformasikan kepada anggota terkait:

1. Perubahan isi dialog, urutan scene, ID pilihan, atau konsekuensi Trust.
2. Perubahan nama/format aset, prefab, GameObject, atau layout UI.
3. Perubahan aturan bukti, kondisi clue, jawaban Final Verdict, atau syarat ending.

---

## 6. Daftar Skenario Uji Minimum

QA menggunakan daftar berikut sebagai cakupan minimal pengujian bersama seluruh anggota.

| ID | Area | Skenario | Hasil yang diharapkan |
|---|---|---|---|
| T-01 | Start Game | Pemain memulai game dari menu utama. | Permainan masuk ke Morning Section. |
| T-02 | Dialogue | Pemain mengklik untuk melanjutkan dialog. | Dialog berikutnya tampil sesuai urutan dan tidak terlewat. |
| T-03 | Dialogue Choice | Pemain memilih salah satu respons. | Cabang dialog sesuai pilihan yang dipilih. |
| T-04 | Trust | Pemain memilih respons yang memiliki perubahan Trust. | Nilai Trust berubah satu kali sesuai konfigurasi. |
| T-05 | Investigation | Pemain mengklik dokumen di meja. | Dokumen terbuka di Document Inspection UI. |
| T-06 | Evidence Comparison | Pemain membandingkan dua informasi yang ditetapkan sebagai petunjuk. | Sistem menampilkan Clue Found dan mencatat petunjuk. |
| T-07 | Evidence Comparison | Pemain membandingkan informasi yang bukan pasangan petunjuk. | Sistem tidak mencatat petunjuk valid. |
| T-08 | Progression | Pemain menyelesaikan objektif satu section. | Pemain dapat melanjutkan ke section berikutnya. |
| T-09 | Final Verdict | Pemain menyerahkan laporan yang benar. | Hasil investigasi dicatat benar dan alur resolusi berjalan. |
| T-10 | Final Verdict | Pemain menyerahkan laporan yang salah. | Hasil salah ditangani sesuai aturan yang disepakati; ending terbaik terkunci apabila aturan final menetapkannya demikian. |
| T-11 | Ending | Pemain menyelesaikan permainan dengan kondisi Professional. | The Report (Professional One) tampil. |
| T-12 | Ending | Pemain menyelesaikan permainan dengan kondisi Companion. | The Confidant (Companion One) tampil. |
| T-13 | Ending | Pemain menyelesaikan permainan dengan kondisi Beloved. | Stay (Beloved One) tampil. |
| T-14 | UI/Resolution | Game dijalankan pada resolusi target PC/Laptop. | Teks dan tombol terbaca, tidak terpotong, dan dapat digunakan. |
| T-15 | Audio | Pemain berpindah antara dialog, investigasi, dan ending. | BGM/SFX yang tersedia sesuai dengan konteks dan tidak bertumpuk secara tidak sengaja. |

---

## 7. Keputusan yang Harus Dikunci Sebelum Implementasi Final

Beberapa detail dalam GDD/storyboard masih perlu disepakati agar programmer, writer, dan QA menggunakan satu aturan yang sama. Jangan menetapkan nilai atau jawaban secara berbeda di script masing-masing.

- [ ] **Pemetaan Trust ke ending:** tentukan nilai awal, perubahan per pilihan, batas/threshold Trust, serta aturan prioritas ketika kondisi ending saling beririsan. GDD menyebut Trust dan keberhasilan analisis sebagai penentu ending, tetapi belum mencantumkan angka threshold.
- [ ] **Syarat keberhasilan investigasi:** tetapkan jumlah petunjuk wajib dan apakah semua petunjuk harus ditemukan sebelum pemain dapat maju ke section berikutnya.
- [ ] **Konsekuensi Final Verdict salah:** GDD menyebut jawaban salah berdampak fatal pada Trust dan mengunci ending terbaik. Tentukan konsekuensi persisnya (misalnya pengurangan Trust atau flag kegagalan) agar dapat diuji.
- [ ] **Konsistensi tanggal dokumen:** storyboard Document Inspection menyebut tanggal Surat Referensi **20 Agustus 1809**, sedangkan bagian Evidence Comparison menyebut **20 Agustus 1808**. Lead Writer perlu menetapkan tanggal final dan menyelaraskan seluruh dokumen/dialog.
- [ ] **Laporan yang benar:** storyboard Final Verdict menyebut **Laporan B** sebagai laporan yang sudah dibuktikan keasliannya. Konfirmasi kembali di evidence & answer key dan gunakan jawaban yang sama di script serta test case.
- [ ] **Pembagian isi Chapter 3:** pastikan bukti utama dan konfrontasi/rekomendasi selesai pada Afternoon Section, sedangkan Final Verdict serta resolusi hubungan dilakukan pada Night Section.
- [ ] **Ending CG:** tentukan apakah ketiga CG dapat diselesaikan sebelum tenggat. CG bukan blocker untuk menyelesaikan mekanik dan alur utama; gunakan placeholder sementara jika diperlukan.

---

## 8. Definition of Done — Kriteria Game Siap Dikumpulkan

Project dapat dinyatakan siap dikumpulkan apabila:

- [ ] Build Unity dapat dijalankan pada PC/Laptop target.
- [ ] Pemain dapat memulai permainan dan menyelesaikan alur Morning, Midday, Afternoon, serta Night.
- [ ] Semua dialog inti dan pilihan respons telah dimasukkan.
- [ ] Pilihan dialog memengaruhi Trust sesuai aturan yang telah dikunci.
- [ ] Pemain dapat membuka dan membandingkan dokumen serta menemukan petunjuk.
- [ ] Mekanik Final Verdict drag-and-drop dapat digunakan dan menangani jawaban benar/salah.
- [ ] Tiga ending dapat dicapai melalui kondisi yang berbeda dan telah diuji.
- [ ] Background, sprite, dokumen, UI, dan audio utama telah terintegrasi atau memiliki placeholder yang disengaja.
- [ ] Tidak ada bug Critical yang diketahui pada build final.
- [ ] QA telah menyelesaikan satu playthrough penuh dan memberikan persetujuan hasil pengujian.
- [ ] Repository berisi versi project yang konsisten dan siap dibuka oleh anggota/dosen.

---

## 9. Catatan Cakupan

Rencana ini memprioritaskan implementasi fitur yang tercantum pada GDD dan storyboard. Fitur di luar rancangan awal—misalnya sistem save/load, pengaturan bahasa, voice acting penuh, atau mekanik tambahan—tidak termasuk prioritas kecuali seluruh fitur inti telah selesai dan kelompok menyepakatinya.
