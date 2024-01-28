import logo from './logo.svg';
import './App.css';
import { loadNetwork } from './store/interactions';
import Navbar from './components/Navbar/Navbar';

function App() {
  const dispatch=useDispatch();
  const loadblockchainData=async()=>{
  const provider=loadProvider(dispatch);
  const chainId=await loadNetwork(provider, dispatch);
  }
  useEffect(()=>{loadblockchainData();})
  return 
    <div className="App">
     <Navbar/>
    </div>;
}

export default App;
