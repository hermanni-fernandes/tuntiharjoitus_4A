# Tuntiharjoitus 4A – Products API (ASP.NET Core)

Tämä projekti toteuttaa yksinkertaisen tuotteiden hakuun perustuvan REST-rajapinnan ASP.NET Core Web API -sovelluksella.  
Toteutus seuraa MVC-arkkitehtuuria sekä hyödyntää Repository- ja Service -suunnittelumalleja.

---

## Projektin rakenne

```
tuntiharjoitus_4A/
├── Controllers/
│ └── ProductsController.cs
├── Models/
│ └── Tuote.cs
├── Repositories/
│ └── ProductsRepository.cs
├── Services/
│ └── ProductsService.cs
├── ProductsApi.csproj
├── Program.cs
└── README.md
```

---

## Toteutetut ominaisuudet

### **1. Malli (Model)**
`Tuote`-luokka kuvaa yksittäistä tuotetta:

- Id  
- Nimi  
- Kuvaus  
- Hinta  

---

### **2. Repository-kerros**
`ProductsRepository` sisältää tuotteiden ”tietokannan” (lista kovakoodatuista tuotteista) sekä metodit:

- `GetAll()` – palauttaa kaikki tuotteet  
- `GetById(id)` – palauttaa tuotteen ID:n perusteella  

Repository vastaa tiedon hakemisesta.

---

### **3. Service-kerros**
`ProductsService` toimii sovelluslogiikan kerroksena ja välittää tietokantakyselyt repositorylle.

- `GetAllProducts()`  
- `GetProductById(id)`  

---

### **4. Controller**
`ProductsController` tarjoaa REST-rajapinnan:

- **GET /api/Products** – palauttaa kaikki tuotteet  
- **GET /api/Products/{id}** – palauttaa yksittäisen tuotteen  

---

## ▶ API:n käynnistäminen

### 1. Asenna riippuvuudet (tarvittaessa)
dotnet restore

### 2. Käynnistä sovellus
dotnet run

Sovellus käynnistyy ja näyttää portin, esim:
Now listening on: http://localhost:5011

---

## API-endpointit

### Hae kaikki tuotteet
**GET**
/api/Products

### Hae tuote ID:n perusteella
**GET**

### Hae tuote ID:n perusteella
**GET**

---

## Swagger-dokumentaatio
Swagger UI löytyy käynnistyksen jälkeen osoitteesta:

http://localhost:5011/swagger

---

## Käytetyt teknologiat

- C#
- ASP.NET Core Web API
- MVC
- Repository Pattern
- Service Layer Pattern
- Swagger / OpenAPI

---

## Tavoite

Harjoituksen tavoitteena on ymmärtää ja toteuttaa:

- ASP.NET Core Web API -sovellus
- kerrosarkkitehtuuri (Controller → Service → Repository)
- erillinen mallikerros (Models)
- testattavat ja selkeät REST-endpointit
- Swagger-dokumentointi

