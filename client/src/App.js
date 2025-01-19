
import React from 'react';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import HomePage from './HomePage'; // ייבוא רכיב דף הבית
import Register from './Register';
import Login from './Login';

function App() {
  return (
    <Router>
      <div>
        <nav>
          <Link to="/">Home</Link>
        </nav>

        <Routes>
          <Route path="/" element={<HomePage />} /> {/* דף הבית */}
        </Routes>
      </div>
    </Router>
  );
}

export default App;
