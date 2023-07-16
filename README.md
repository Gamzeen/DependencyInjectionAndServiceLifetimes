# Service Lifetimes Projesi
Bu proje, bir API’de Controller’a 2 kez request  göndererek yanıtları karşılaştırmayı amaçlayan basit bir uygulamadır. Proje, 3 farklı servis türü (transient, scoped, singleton) ve bir controller içerir.

# Proje Açıklaması

Dependency Injection kullanıldığında, servislerin nasıl oluşturulduğu ve ömür döngüleri önemli rol oynar. Bu projede ingleton, Scoped ve Transient olmak üzere üç farklı servis ömür döngüsünü inceleyeceğiz.

Service Lifetimes projesi, bir API'nin farklı servis ömürleriyle nasıl davrandığını anlamak ve bu servislerin taleplere nasıl yanıt verdiğini karşılaştırmak için tasarlanmıştır. Projede, aynı API'ye 2 kere  request gönderilir ve her request’in yanıtı karşılaştırılır. Bu sayede, farklı servis ömürleri (transient, scoped, singleton) arasındaki farklar gözlemlenebilir.

# Nasıl Çalışır?
Proje, aşağıdaki bileşenleri içerir:
* SingletonService: Uygulama bazlı tekil nesne oluşturulur. Tüm taleplere o nesneyi gönderir.
* ScopedService: Her request başına bir nesne üretir ve o request pipeline'ında  olam tüm isteklere o nesneyi gönderir.
* TransientService: Her request'in her talebine karşılık bir nesne üretir ve gönderir.
* ServiceController: API taleplerini yöneten ve servislerle iletişim kuran bir controller.

<img width="540" alt="Screenshot 2023-07-16 at 19 00 25" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/3db305ba-dbba-4064-ab3c-bd4c9e365436">

<img width="551" alt="Screenshot 2023-07-16 at 19 01 17" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/6f2a8270-57f6-4f7e-9334-e7e68d41a481">


Proje başlatıldığında, ServiceController, API'ye 2 kez talep gönderirseniz elde edeceğiniz response’lar şu şekilde olur : 


Response 1 :
<img width="479" alt="Screenshot 2023-07-16 at 17 44 48" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/5abc02b3-6bf8-4576-abf8-ab76efb1b6e5">


Request 2 : 
<img width="483" alt="Pasted Graphic" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/659bc5e8-7dba-4f5a-bf9f-56889f7b7be5">

## Kurulum

Projeyi klonlayın

```bash
  git clone https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes.git
```
## Kaynakça
 https://henriquesd.medium.com/dependency-injection-and-service-lifetimes-in-net-core-ab9189349420
https://www.c-sharpcorner.com/article/dependency-injection-service-lifetimes/
https://stackoverflow.com/questions/38138100/addtransient-addscoped-and-addsingleton-services-differences
https://www.buraksenyurt.com/post/asp-net-core-dependency-lifetimes
https://gokhana.medium.com/dependency-injection-nedir-nas%C4%B1l-uygulan%C4%B1r-kod-%C3%B6rne%C4%9Fiyle-44f4b0d576e4
https://endjin.com/blog/2022/09/service-lifetimes-in-aspnet-core
https://medium.com/kodcular/asp-net-core-dependency-lifetimes-52cc89043398
https://www.c-sharpcorner.com/article/understanding-addtransient-vs-addscoped-vs-addsingleton-in-asp-net-core/#:~:text=Transient%20lifetime%20services%20are%20created,best%20for%20lightweight%2C%20stateless%20services.&text=Scoped%20lifetime%20services%20are%20created%20once%20per%20request.
