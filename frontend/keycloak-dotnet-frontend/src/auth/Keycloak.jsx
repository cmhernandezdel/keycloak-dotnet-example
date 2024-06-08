import Keycloak from 'keycloak-js';
const keycloak = new Keycloak({
    url: "https://localhost:8443/auth",
    realm: "example-realm",
    clientId: "react-frontend"
});

export default keycloak;