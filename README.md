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

