import className from 'classnames/bind';
import { createContext } from 'react';
import styles from './Header.module.scss';
const cx = className.bind(styles);
function Header() {
    return (
        <div className={cx('wrapper')}>
            <div className={cx('inner')}></div>
        </div>
    );
}

export default Header;
