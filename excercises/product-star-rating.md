# 📊 Zadanie: Komponent oceniania produktu

## 🧩 Cel:
Twoim zadaniem jest stworzenie komponentu Blazora, który umożliwia użytkownikowi ocenę produktu w skali od `1` do `5` za pomocą interaktywnych gwiazdek. Komponent ma być niezależny i gotowy do ponownego użycia w różnych miejscach aplikacji.
---

## ✅ Wymagania funkcjonalne:
1. **Stwórz komponent** `StarRating.razor`, który:
- Wyświetla 5 gwiazdek w jednym rzędzie
- Podświetla gwiazdki zgodnie z aktualną oceną (np. wypełniona ikonka dla aktywnych gwiazdek, pusta dla pozostałych)
- Pozwala kliknąć w dowolną gwiazdkę w celu ustawienia oceny (1–5)

2. **W komponencie nadrzędnym** (`ProductView.razor`):
- Osadź komponent `StarRating`
- Przechowuj aktualną ocenę jako `int`
- Po zmianie oceny wyświetl informację tekstową, np.: **„Dziękujemy! Twoja ocena: 4/5”**

--- 

## 💡 Wskazówki 
- Wypełniona gwiazdka: `<i class="bi bi-star-fill text-warning"></i>`
- Pusta gwiazdka: `<i class="bi bi-star text-muted"></i>`
- Styl CSS: możesz zastosować klasę `cursor: pointer` do klikanych elementów


---

## ⏱️ Czas realizacji: **45 minut**

W razie pytań — zapytaj prowadzącego 🙂