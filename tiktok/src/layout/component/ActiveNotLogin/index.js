import styles from './ActiveNotLogin.module.scss';
import className from 'classnames/bind';
import { MoreIcon, UploadIcon } from '~/component/icons';
import Button from '~/component/Button';
function ActiveNotLogin() {
    const cx = className.bind(styles);

    return (
        // class login upload
        <div className={cx('ActiveNotLogin')}>
            <Button text>Upload</Button>

            <Button primary>Log in</Button>
            {/* <button className={cx('upload')}>Upload</button>
            <button className={cx('login')}>log in</button> */}
            <MoreIcon classNamePr={cx('moreIcon')} />
        </div>
    );
}

export default ActiveNotLogin;
