## EF Core Prodecure ve Function Yapıları
# Merhabalar, bu yazımda SP ve Function arasındaki farklardan çok kısa bahsedeceğim.

Stored Procedure (SP), parametre alabilen fakat geriye bir değer döndürmeyen alt programlardır. Yani database tarafında saklanan ve ilk derlemeden sonra tekrar derlenmeye ihtiyaç duyulmayan sql ifadesi de denilebilir. Tekrar derlenmediği için performansı da oldukça yüksektir.
Function (User Defined Function), istenilen değer tipinde geri dönüş yapabilen sql kodudur.

Stored procedure lerin geri dönüş değer olmayabilir, fakat Function‘lar her zaman geriye bir değer (sayı, text, tablos vs.) döndürmek zorundadır.
Stored procedure lerin hem input hem de output parametreleri vardır, fakat Function‘ların sadece input parametreleri vardır.
Stored procedure ler function tarafından çağrılamaz, fakat Function‘lar Stored procedure tarafından çalıştırılabilir.
Stored procedure ler CRUD (Create/Read/Update/Delete) işlemlerinin hepsini yapabilir, fakat Function‘lar sadece Select ile kullanılabilir.
Stored procedure lerde try-catch yapısı kullanılabilir, fakat Function‘larda try-catch yapısını kullanamazsınız.
Stored procedure ler transaction yapısını destekler, fakat Function‘lar transaction yapısını desteklemez.
