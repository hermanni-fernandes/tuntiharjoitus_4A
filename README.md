# Tuntiharjoitus 4A – Category + Products API (ASP.NET Core)

Tämä projekti toteuttaa REST-rajapinnan ASP.NET Core Web API -sovelluksella.  
Tehtävän tavoitteena oli lisätä kategoriaominaisuus (Category) aiempaan tuotteiden API:in.

Toteutus sisältää REST-endpointit kategorioille, kategorian omistajan lisäyksen sekä sen, että jokainen tuote (Tuote) kuuluu johonkin kategoriaan.

---

## Projektin rakenne

```
tuntiharjoitus_4A/
├── Controllers/
│ ├── ProductsController.cs
│ └── CategoriesController.cs
├── Models/
│ ├── Tuote.cs
│ └── Category.cs
├── Repositories/
│ ├── ProductsRepository.cs
│ └── CategoriesRepository.cs
├── Services/
│ ├── ProductsService.cs
│ └── CategoriesService.cs
├── Program.cs
└── README.md
```

---

## Toteutetut ominaisuudet (Tehtävä 4A)

### 1. Category-malli
Category sisältää seuraavat kentät:
- **Id** (yksilöllinen tunniste)
- **Name** (uniikki tekstikenttä)
- **Owner** (sisäänkirjautunut käyttäjä – mockattu arvoksi `"test_user"`)

### 2. Category REST-endpointit
| Metodi | Polku | Kuvaus |
|--------|-------|--------|
| GET | `/api/categories` | Hae kaikki kategoriat |
| GET | `/api/categories/{id}` | Hae yksittäinen kategoria omistajatiedon kanssa |
| POST | `/api/categories` | Lisää uusi kategoria, johon lisätään omistaja automaattisesti |

**Owner lisätään aina automaattisesti palvelimella**, eikä sitä lähetetä pyynnössä.

### 3. Tuote kuuluu kategoriaan
Tuote-malliin lisättiin kenttä:
public int CategoryId { get; set; }

Mock-dataan lisättiin tuotteille kategoriat, esim.:
- Kahvi ja Tee → kategorian Id = 1
- Suklaa → kategorian Id = 2

---

## Testaus Swaggerilla

Käynnistä sovellus:

dotnet run

Swagger UI löytyy:

### Testattavat kohdat:
✔ GET `/api/categories` → palauttaa kategoriat  
✔ POST `/api/categories` → palauttaa automaattisesti Owner = `"test_user"`  
✔ GET `/api/products` → sisältää CategoryId jokaisella tuotteella

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

Oppia:
- lisäämään uutta ominaisuutta olemassa olevaan API:in
- kerrosarkkitehtuuri (Controller → Service → Repository)
- mallien laajentaminen ja endpointtien lisääminen
- automaattisen dokumentaation hyödyntäminen (Swagger)
