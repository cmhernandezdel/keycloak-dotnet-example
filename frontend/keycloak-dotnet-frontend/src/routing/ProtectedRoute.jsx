import { useKeycloak } from '@react-keycloak/web';
import PropTypes from "prop-types";

const ProtectedRoute = (props) => {
    const { keycloak } = useKeycloak();
    const isLoggedIn = keycloak.authenticated;
    return isLoggedIn ? props.children : null;
}

export default ProtectedRoute;

ProtectedRoute.propTypes = {
    children: PropTypes.any
}