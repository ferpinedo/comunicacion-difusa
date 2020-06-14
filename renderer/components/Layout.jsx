const Layout = ({ children }) => (
  <>
    <div className="flex p-4 px-8 justify-between">
      <div className="flex space-x-4">
        <img src="/images/its.png" alt="" />
        <div className="flex flex-col">
          <span>Instituto Tecnológico de Saltillo</span>
          <span>Taller de Investigación 2</span>
        </div>
      </div>
    </div>
    {children}
  </>
);

export default Layout;
