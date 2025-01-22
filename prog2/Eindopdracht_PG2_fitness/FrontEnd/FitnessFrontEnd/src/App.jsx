import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

const App = () => {
  const [data, setData] = useState([]); 
  const [filteredData, setFilteredData] = useState([]);
  const [email, setEmail] = useState(""); 
  const [searchInitiated, setSearchInitiated] = useState(false);
  const navigate = useNavigate();

  useEffect(() => {
    fetch("http://localhost:5253/api/Member")
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error(error));
  }, []);

  const handleSearch = () => {
    setSearchInitiated(true); 
    if (email.trim() === "") {
      setFilteredData([]); 
    } else {
      const result = data.filter((member) =>
        member.email.toLowerCase() === email.toLowerCase()
      );
      setFilteredData(result);
    }
  };

  const handleNavigate = (memberID) => {
    navigate(`/FitnessBeheerPage/${memberID}`);
  };

  return (
    <div style={{ fontFamily: "Arial, sans-serif", padding: "20px", backgroundColor: "#f5f5f5", height:"543px" }}>
      <h1 style={{ textAlign: "center", color: "#333" }}>Data van de API</h1>

      {/* zoekveldje */}
      <div style={{ marginBottom: "20px", textAlign: "center" }}>
        <input
          type="text"
          placeholder="Zoek op e-mailadres..."
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          style={{
            padding: "10px",
            width: "300px",
            border: "1px solid #ccc",
            borderRadius: "4px",
            marginRight: "10px",
          }}
        />
        <button
          onClick={handleSearch}
          style={{
            padding: "10px 20px",
            backgroundColor: "#007BFF",
            color: "#fff",
            border: "none",
            borderRadius: "4px",
            cursor: "pointer",
            transition: "background-color 0.3s ease",
          }}
          onMouseOver={(e) => (e.target.style.backgroundColor = "#0056b3")}
          onMouseOut={(e) => (e.target.style.backgroundColor = "#007BFF")}
        >
          Zoek
        </button>
      </div>

      {/* results of melding */}
      <div style={{ textAlign: "center" }}>
        {!searchInitiated && (
          <p style={{ color: "#666" }}>Voer eerst een e-mailadres in om een lid te zoeken.</p>
        )}

        {searchInitiated && filteredData.length === 0 && (
          <p style={{ color: "#ff0000" }}>Geen lid gevonden met dit e-mailadres.</p>
        )}
      </div>

      {/* members */}
      <ul style={{ listStyle: "none", padding: "0" }}>
        {filteredData.map((member, index) => (
          <li
            key={index}
            style={{
              display: "inline-block",
              
              backgroundColor: "#fff",
              padding: "20px",
              margin: "10px 0",
              borderRadius: "8px",
              boxShadow: "10 10px 10px rgba(0, 0, 0, 0.76)",
            }}
          >
            <button
              onClick={() => handleNavigate(member.memberID)}
              style={{
                display: "inline-block",
                padding: "10px 20px",
                marginBottom: "10px",
                backgroundColor: "#007BFF",
                color: "#fff",
                border: "none",
                borderRadius: "4px",
                cursor: "pointer",
                transition: "background-color 0.3s ease",
              }}
              onMouseOver={(e) => (e.target.style.backgroundColor = "#0056b3")}
              onMouseOut={(e) => (e.target.style.backgroundColor = "#007BFF")}
            >
              Maak reservatie
            </button>
            <p style={{ margin: "5px 0" }}>
              <strong>Lidnummer:</strong> {member.memberID}
            </p>
            <p style={{ margin: "5px 0" }}>
              <strong>Naam:</strong> {member.firstName} {member.lastName}
            </p>
           
            <p style={{ margin: "5px 0" }}>
              <strong>E-mail:</strong> {member.email}
            </p>
            <p style={{ margin: "5px 0" }}>
              <strong>Adres:</strong> {member.adress}
            </p>
            <p style={{ margin: "5px 0" }}>
              <strong>Type klant:</strong> {member.memberType}
            </p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default App;
