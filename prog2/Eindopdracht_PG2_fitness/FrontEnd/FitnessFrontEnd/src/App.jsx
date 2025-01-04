import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";

const App = () => {
  const [data, setData] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    fetch("http://localhost:5253/api/Member/GetAll")
      .then((response) => response.json())
      .then((data) => setData(data))
      .catch((error) => console.error(error));
  }, []);

  const handleNavigate = (memberID) => {
    navigate(`/FitnessBeheerPage/${memberID}`);
  };

  return (
    <div style={{ fontFamily: "Arial, sans-serif", padding: "20px", backgroundColor: "#f5f5f5" }}>
      <h1 style={{ textAlign: "center", color: "#333" }}>Data van de API</h1>
      <ul style={{ listStyle: "none", padding: "0" }}>
        {data.map((member, index) => {
          return (
            <li
              key={index}
              style={{
                backgroundColor: "#fff",
                padding: "20px",
                margin: "10px 0",
                borderRadius: "8px",
                boxShadow: "0 4px 6px rgba(0, 0, 0, 0.1)",
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
                <strong>MemberID:</strong> {member.memberID}
              </p>
              <p style={{ margin: "5px 0" }}>
                <strong>FirstName:</strong> {member.firstName}
              </p>
              <p style={{ margin: "5px 0" }}>
                <strong>LastName:</strong> {member.lastName}
              </p>
              <p style={{ margin: "5px 0" }}>
                <strong>Email:</strong> {member.email}
              </p>
              <p style={{ margin: "5px 0" }}>
                <strong>Adress:</strong> {member.adress}
              </p>
              <p style={{ margin: "5px 0" }}>
                <strong>Birthday:</strong> {member.birthday}
              </p>
              <p style={{ margin: "5px 0" }}>
                <strong>Interests:</strong> {member.interests.join(", ")}
              </p>
              <p style={{ margin: "5px 0" }}>
                <strong>MemberType:</strong> {member.memberType}
              </p>
            </li>
          );
        })}
      </ul>
    </div>
  );
};

export default App;
