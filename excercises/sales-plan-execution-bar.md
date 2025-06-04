# 📈 Zadanie: Pasek postępu realizacji planu sprzedaży#


## 🧩 Cel
Celem zadania jest rozbudowanie kafelka dashboardu o pasek postępu, który pokazuje realizację planu sprzedaży — np. `66 / 100 produktów sprzedanych`. 

---

## ✅ Wymagania funkcjonalne:

1. Komponent `ProgressBar.razor`
Stwórz komponent wyświetlający pasek postępu w procentach.

- Pasek powinien automatycznie odczytywać dane o postępie (Current / Total)
- Prezentuj postęp w formie graficznej (np. pasek Bootstrap)
- Pasek powinien być osadzony w innych komponentach, bez konieczności jawnego przekazywania parametrów w każdej warstwie

2. Strona `Dashboard.razor`
- Dodaj do strony kafelek z osadzonym paskiem postępu.

## ✅ Przykładowa wizualizacja kafelka:

Realizacja planu: `66 / 100`

[██████████░░░░░░░░░░░░░░░░] 66%



---

## 💡 Wskazówki
- Do obliczeń możesz użyć: `int Percent => Current * 100 / Total`

---


## ⏱️ Czas realizacji: **45 minut**


W razie pytań — zapytaj prowadzącego 🙂