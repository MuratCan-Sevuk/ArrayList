

````markdown
# MyArrayList

**MyArrayList**, C# dilinde yazılmış, temel liste işlemlerini gerçekleştiren **basit bir dinamik dizi (ArrayList)** sınıfıdır.

Bu sınıf kendi koleksiyon sınıfınızı yazmanıza yardımcı olur; eleman ekleme, araya ekleme, silme, eleman çekme ve listeyi yazdırma gibi temel işlevleri içerir.

## 📌 Özellikler

✅ Eleman ekleme (`Add`)  
✅ Belirli bir indekse eleman ekleme (`Insert`)  
✅ Belirli bir indeksteki elemanı silme (`RemoveAt`)  
✅ İndeks ile eleman çekme (`Get`)  
✅ Eleman sayısını döndüren `Count` özelliği  
✅ Listeyi string olarak döndüren `ToString` metodu  
✅ Gerektiğinde kapasiteyi artırma (otomatik)

## 🚀 Çalıştırma

1. **Visual Studio** veya bir C# geliştirme ortamında açın.
2. Kodları bir **Console App (.NET Framework veya .NET Core)** projesine yapıştırın.
3. Programı derleyip çalıştırın.

Alternatif olarak terminal üzerinden:

```bash
dotnet build
dotnet run
````

## 📝 Örnek Çıktı

Program `Main` metodunu çalıştırdığında aşağıdaki gibi bir çıktı üretir:

```
123
Eleman Sayısı: 2
Liste: Dünya, 123
```

Açıklama:

* `"Merhaba"` eklendi
* `123` eklendi
* İndeks `1`'e `"Dünya"` eklendi
* İndeks `0`'daki `"Merhaba"` silindi
* İndeks `1`'deki eleman (`123`) ekrana yazdırıldı
* Liste ve eleman sayısı ekrana yazdırıldı

## 💡 Notlar

* `Insert` metodu için geçersiz bir indeks verilirse, hata mesajı ekrana yazdırılır.
* `RemoveAt` metodu geçersiz bir indeks için `ArgumentOutOfRangeException` fırlatır.
* `Get` metodu geçersiz bir indeks için `null` döner.
* Kapasite ilk başta **4** eleman için tanımlıdır, ihtiyaç duyuldukça 2'şer artırılır.

## 📂 Dosya Yapısı

```
/MyArrayList
 ├── MyArrayList.cs
 ├── Program.cs
 └── README.md
```

🛠️ Bu proje, temel veri yapıları ve nesne tabanlı programlama (OOP) öğrenimi için harika bir örnektir.

