# Belangrijke Array-Methoden in React

In React werk je veel met arrays en objecten. Hier zijn enkele van de meest gebruikte array-methoden:

## 1. `.map()`

**Wat doet het?**  
Hiermee kun je een array transformeren in een nieuwe array, meestal gebruikt om JSX-componenten te genereren.

**Voorbeeld:**
```jsx
const fruits = ['Apple', 'Banana', 'Cherry'];

function FruitList() {
  return (
    <ul>
      {fruits.map((fruit) => (
        <li key={fruit}>{fruit}</li>
      ))}
    </ul>
  );
}
```

## 2. `.filter()`

**Wat doet het?**  
Hiermee kun je een array filteren op basis van een voorwaarde.

**Voorbeeld:**
```jsx
const fruits = ['Apple', 'Banana', 'Cherry'];

function FilteredList() {
  const filtered = fruits.filter((fruit) => fruit.startsWith('B'));

  return (
    <ul>
      {filtered.map((fruit) => (
        <li key={fruit}>{fruit}</li>
      ))}
    </ul>
  );
}
```

## 3. `.find()`

**Wat doet het?**  
Hiermee kun je het eerste element vinden dat voldoet aan een voorwaarde.

**Voorbeeld:**
```jsx
const fruits = [
  { name: 'Apple', color: 'red' },
  { name: 'Banana', color: 'yellow' },
  { name: 'Cherry', color: 'red' },
];

function FindFruit() {
  const redFruit = fruits.find((fruit) => fruit.color === 'red');
  return <p>First red fruit: {redFruit.name}</p>;
}
```

## 4. `.sort()`

**Wat doet het?**  
Hiermee kun je een array sorteren.

**Voorbeeld:**
```jsx
const numbers = [3, 1, 4, 1, 5, 9];

function SortedNumbers() {
  const sorted = [...numbers].sort((a, b) => a - b); // Kopieer de array voor sorteren
  return <p>Sorted numbers: {sorted.join(', ')}</p>;
}
```

## 5. `.reduce()`

**Wat doet het?**  
Hiermee kun je een array reduceren tot een enkele waarde (bijvoorbeeld een som).

**Voorbeeld:**
```jsx
const numbers = [1, 2, 3, 4];

function Total() {
  const sum = numbers.reduce((acc, num) => acc + num, 0);
  return <p>Total: {sum}</p>;
}
```

---

Door deze methoden te beheersen, kun je efficiënter werken met data in React en overzichtelijkere componenten maken.
