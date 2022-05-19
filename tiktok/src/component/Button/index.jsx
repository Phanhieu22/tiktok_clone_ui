import classnames from 'classnames/bind';
import style from './Button.module.scss';
import { Link } from 'react-router-dom';

const cx = classnames.bind(style);

function Button({
    children,
    to,
    primary,
    outline,
    href,
    small,
    large,
    disabled,
    onClick,
    rounded,
    text,
    leftIcon,
    rightIcon,
    className,
    ...passProps
}) {
    let Comp = 'button';

    let props = {
        onClick,
        ...passProps,
    };
    if (disabled) {
        Object.keys(props).forEach((key) => {
            if (key.startsWith('on') && typeof props[key] === 'function') {
                delete props[key];
            }
        });
    }

    if (to) {
        Comp = Link;
        props.to = to;
    } else if (href) {
        Comp = 'a';

        props.href = href;
    }

    return (
        <Comp
            className={cx('wrapper', {
                [className]: className,
                primary,
                outline,
                small,
                large,
                text,
                disabled,
                rounded,
            })}
            {...props}
        >
            {leftIcon && <span className={cx('icon')}>{leftIcon}</span>}
            <span className={cx('title')}>{children}</span>
            {rightIcon && <span className={cx('icon')}>{rightIcon}</span>}
        </Comp>
    );
}

export default Button;
