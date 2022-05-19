import className from 'classnames/bind';
import styles from './ActiveLogin.module.scss';
const { UploadIcon, MessageIcon, InboxIcon } = require('~/component/icons');

function ActiveLogin() {
    const cx = className.bind(styles);
    return (
        <div className={cx('ActiveLogin')}>
            <UploadIcon height="32px" width="32px" />
            <MessageIcon height="32px" width="26px" />
            <InboxIcon height="32px" width="32px" />
        </div>
    );
}

export default ActiveLogin;
