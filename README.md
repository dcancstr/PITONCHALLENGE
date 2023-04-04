# Merhaba,

Proje hakkında bir kaç bilgi vermek istiyorum.
Projenin authorize edilmesi için öncellikle bir User Controllerından bir user oluşturulup,
daha sonra Authorization Controllerından giriş yapılıp eşleşme olması halinde bir token üretilecektir.
Bu tokenla swagger sağ üstten Authorize butonuyla token eşleştirilecektir. Proje RunTime boyunca Authorize edilmiş olacaktır.
Doğrulama sonrası ancak Mission ve MissionCategory Controllerına ulaşabiliyoruz.
Bunun ardından gerekli işlemlere tabi tutabiliyoruz.
PostgreSQL BackUp'ı (scripti) DataAccess klasörü içindedir.
