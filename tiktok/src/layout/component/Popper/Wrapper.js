import styles from './Popper.module.scss';
import className from 'classnames/bind';
function Wrapper({children}) {
    const cx = className.bind(styles);
    return <div className={cx('wrapper', className)}>{children}</div>;
}

export default Wrapper;
