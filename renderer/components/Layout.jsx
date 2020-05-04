const Layout = ({ children }) => (
  <div>
    <div className="top-bar">
      <div className="its-container ">
        {/* <img src={"/its.png"} alt="Logo de ITS" /> */}
        <div className="its-name">
          <span>Instituto Tecnológico de Saltillo</span>
          <span>Taller de Investigación 2</span>
        </div>
      </div>
      <div>ÍCONO DE AUDIO</div>
    </div>
    {children}
    <style global jsx>{`
      body {
        background-color: #f1f1f1;
      }
      .top-bar {
        display: flex;
        padding: 10px;
        justify-content: space-between;
      }
      .its-container {
        display: flex;
      }
      .its-name {
        display: flex;
        flex-direction: column;
      }
      a {
        color: inherit; /* blue colors for links too */
        text-decoration: inherit; /* no underline */
      }
    `}</style>
  </div>
);

export default Layout;
