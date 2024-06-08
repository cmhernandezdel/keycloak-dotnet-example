import './App.css'
import { ReactKeycloakProvider } from '@react-keycloak/web';
import keycloak from './auth/Keycloak';
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Landing from './pages/Landing';
import UserAccount from './pages/UserAccount';
import ProtectedRoute from './routing/ProtectedRoute';
import { StrictMode } from 'react';

function App() {

  return (
    <>
      <ReactKeycloakProvider authClient={keycloak} >
        <StrictMode>
          <BrowserRouter>
            <Routes>
              <Route exact path="/" element={<Landing />} />
              <Route exact path="/account" element={<ProtectedRoute><UserAccount /></ProtectedRoute>} />
            </Routes>
          </BrowserRouter>
        </StrictMode>
      </ReactKeycloakProvider>
    </>
  )
}

export default App
