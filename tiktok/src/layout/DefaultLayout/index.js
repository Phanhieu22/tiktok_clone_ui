import Header from '~/layout/component/Header';
import SideBar from './SideBar';

function Defaultpage({ children }) {
    return (
        <div>
            <Header />
            <div className="container">
                <SideBar />
                <div className="content">{children}</div>
            </div>
        </div>
    );
}

export default Defaultpage;
