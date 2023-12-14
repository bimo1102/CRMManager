// import { useState } from 'react'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.min.js';
import './App.css'
import { QueryClient, QueryClientProvider } from 'react-query';
import { Route, Routes } from 'react-router-dom';
import { MainLayout } from './common/layout/main.layout';
import { CustomerPage } from './Pages/customer/customer.page';

function App() {

  const queryClient = new QueryClient()
  return (
    <>
      <QueryClientProvider client={queryClient}>
        <Routes>
          <Route path='/' element={<MainLayout />}>
            <Route path='/customers' element={<CustomerPage />}></Route>
          </Route>
        </Routes>
      </QueryClientProvider>
    </>
  )
}

export default App
