package org.com.designpattern.core;

public interface BeanBuildableType<T>
    extends
    DPBuildableType<T> {

    T getBean();
}
