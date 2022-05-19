import className from 'classnames/bind';
import images from '~/assets/images';
import ActiveNotLogin from '../ActiveNotLogin';
import Search from '../Search';
import styles from './Header.module.scss';
function Header() {
    const cx = className.bind(styles);

    return (
        <div className={cx('wrapper')}>
            <div className={cx('inner')}>
                <div className={cx('logo')}>
                    <img src={images.logo} alt="tiktok" />
                </div>

                <Search />

                {/* <ActiveLogin /> */}
                <ActiveNotLogin />
            </div>
        </div>
    );
}

export default Header;
