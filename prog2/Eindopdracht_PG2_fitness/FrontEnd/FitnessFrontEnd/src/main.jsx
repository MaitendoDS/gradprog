// import React from "react";
import ReactDOM from "react-dom/client"
import { createBrowserRouter, RouterProvider } from 'react-router-dom';
import RootLayout from './Navigation/RootLayout';
import HomePage from './App.jsx';
import FitnessBeheerPage from "./FitnessBeheerPage.jsx";

const router = createBrowserRouter([
  {
    path: '/',
    element: <RootLayout />,
    children: [
      { path: '/', element: <HomePage /> },     
      { path: '/FitnessBeheerPage/:id', element : <FitnessBeheerPage /> }
    ],
  },
]);

ReactDOM.createRoot(document.getElementById('root')).render(
  //<React.StrictMode>
    <RouterProvider router={router} />
  //</React.StrictMode>
);
