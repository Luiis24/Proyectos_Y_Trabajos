import logo from './logo.svg';
import './App.css';
import { PrimerComponente } from './componentesreact/PrimerComponente';
import { SegundoComponente } from './componentesreact/SegundoComponente';
import { TercerComponente } from './componentesreact/TercerComponente';
import { CuartoComponente } from './componentesreact/CuartoComponente';
import { QuintoComponente } from './componentesreact/QuintoComponente';
import { SextoComponenete } from './componentesreact/SextoComponenete';
import { SeptimoComponente } from './componentesreact/SeptimoComponente';
import { OctavoComponente } from './componentesreact/OctavoComponente';
import { NovenoComponente } from './componentesreact/NovenoComponente';
import { Espacio } from './componentesreact/Espacio';

function App() {
  return (
    <div className="App">
      <PrimerComponente />
      <Espacio />
      <SegundoComponente />
      <Espacio />
      <TercerComponente />
      <Espacio />
      <CuartoComponente />
      <Espacio />
      <QuintoComponente />
      <Espacio />
      <SextoComponenete />
      <Espacio />
      <SeptimoComponente />
      <Espacio />
      <Espacio />
      <OctavoComponente />
      <Espacio />
      <Espacio />
      <NovenoComponente />
      <Espacio />
    </div>
  );
}

export default App;
