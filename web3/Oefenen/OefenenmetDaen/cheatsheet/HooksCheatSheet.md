# React Cheatsheet
## Hooks

# `useState` Hook
**Wat doet het?**  
Hiermee kun je lokale state toevoegen aan een functioneel component.

**Gebruiksscenario's:**  
- Bijhouden van een eenvoudige waarde zoals invoer, een teller, of een status.

**Voorbeeld:**
```jsx
import React, { useState } from 'react';

function Counter() {
  const [count, setCount] = useState(0);

  return (
    <div>
      <p>You clicked {count} times</p>
      <button onClick={() => setCount(count + 1)}>Click me</button>
    </div>
  );
};
```
# `useEffect` Hook
## Wat doet het?
Hiermee kun je bijwerkingen uitvoeren in je component, zoals data ophalen, event listeners toevoegen, of DOM-updates doen.

## Gebruiksscenario's:
- Data ophalen van een API.
- Een event listener toevoegen en opruimen.

## Voorbeeld:
```jsx
import React, { useState, useEffect } from 'react';

function Timer() {
  const [seconds, setSeconds] = useState(0);

  useEffect(() => {
    const interval = setInterval(() => {
      setSeconds((prev) => prev + 1);
    }, 1000);

    // Cleanup de interval
    return () => clearInterval(interval);
  }, []); // Lege array betekent: alleen uitvoeren bij de eerste render

  return <p>Seconds elapsed: {seconds}</p>;
}
```
# `useRef` Hook

## Wat doet het?
Hiermee kun je een referentie naar een DOM-element of een mutable object bijhouden die geen her-render veroorzaakt.

## Gebruiksscenario's:
- Toegang tot een DOM-element (bijvoorbeeld een input focussen).
- Een waarde bijhouden die tussen renders niet verloren gaat zonder dat een her-render wordt veroorzaakt.

## Voorbeeld:
```jsx
import React, { useRef } from 'react';

function FocusInput() {
  const inputRef = useRef(null);

  const focusInput = () => {
    inputRef.current.focus();
  };

  return (
    <div>
      <input ref={inputRef} type="text" />
      <button onClick={focusInput}>Focus Input</button>
    </div>
  );
}
```
# `useContext` Hook
## Wat doet het?
Hiermee kun je data delen tussen componenten zonder expliciete props door te geven (via context).

## Gebruiksscenario's:
- Thema (licht/donker).
- Authenticatie (is de gebruiker ingelogd?).

## Voorbeeld:
```jsx
import React, { createContext, useContext } from 'react';

const ThemeContext = createContext('light');

function App() {
  return (
    <ThemeContext.Provider value="dark">
      <Toolbar />
    </ThemeContext.Provider>
  );
}

function Toolbar() {
  const theme = useContext(ThemeContext);
  return <p>The current theme is {theme}</p>;
}
```
