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




# Service Lifetimes Project

This project is a simple application that aims to compare the responses by sending two requests to a Controller in an API. The project includes three different types of services (transient, scoped, singleton) and a controller.

# Project Description

When using Dependency Injection, the creation and lifecycle of services play an important role. In this project, we will examine three different service lifetimes: Singleton, Scoped, and Transient.

The Service Lifetimes project is designed to understand how an API behaves with different service lifetimes and to compare how these services respond to requests. In the project, two requests are sent to the same API, and the responses of each request are compared. This allows us to observe the differences between different service lifetimes (transient, scoped, singleton).

# How Does It Work?

The project includes the following components:

SingletonService: Creates a singleton object on an application-wide basis. It sends that object to all requests.
ScopedService: Creates an object per request and sends that object to all requests within the request pipeline.
TransientService: Creates an object for each individual request and sends it.
ServiceController: Manages API requests and communicates with the services.

<img width="540" alt="Screenshot 2023-07-16 at 19 00 25" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/3db305ba-dbba-4064-ab3c-bd4c9e365436">

<img width="551" alt="Screenshot 2023-07-16 at 19 01 17" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/6f2a8270-57f6-4f7e-9334-e7e68d41a481">

When the project is launched, if you send two requests to the API, the responses you would obtain would be as follows:

Response 1 :
<img width="479" alt="Screenshot 2023-07-16 at 17 44 48" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/5abc02b3-6bf8-4576-abf8-ab76efb1b6e5">


Request 2 : 
<img width="483" alt="Pasted Graphic" src="https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes/assets/74109466/659bc5e8-7dba-4f5a-bf9f-56889f7b7be5">

## Setup

Clone the project

```bash
  git clone https://github.com/Gamzeen/DependencyInjectionAndServiceLifetimes.git
```
