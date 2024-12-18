import { NavLink } from 'react-router-dom';

const Header = () => {
  return (
    <div
      style={{
        backgroundColor: '#3b82f6', 
        color: 'white', 
        height: '6rem', 
        display: 'flex', 
        alignItems: 'center', 
        justifyContent: 'space-between', 
        padding: '0 1.5rem', 
        margin: '0', 
      }}
    >
      <p style={{ fontSize: '1.875rem', fontWeight: '300' }}> 
        YouMove fitness Dashboard
      </p>
      <div style={{ display: 'flex', gap: '1.5rem' }}> 
        <NavLink
          to="/"
          style={({ isActive }) =>
            isActive
              ? {
                  textDecoration: 'underline',
                  textUnderlineOffset: '8px', 
                  fontWeight: 'bold', 
                }
              : {
                  textDecoration: 'none',
                }
          }
        >
          Home
        </NavLink>
      </div>
    </div>
  );
};

export default Header;
