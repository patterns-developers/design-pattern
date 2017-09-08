package org.com.designpattern.core;

public abstract class AbstractTemplateBuilder<T>
    implements
    BeanBuildableType<T> {

    private final T bean;

    protected AbstractTemplateBuilder(
        final T bean) {
        this.bean = bean;
    }

    public T getBean() {
        return this.bean;
    }
}
