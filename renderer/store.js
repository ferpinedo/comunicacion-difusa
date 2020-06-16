import { action, observable, computed, runInAction } from "mobx";
import { useStaticRendering } from "mobx-react";
import { useMemo } from "react";
// eslint-disable-next-line react-hooks/rules-of-hooks
useStaticRendering(typeof window === "undefined");

let store;

class Store {
  @observable editingStudent = {};
  @observable results = {
    date: new Date(),
    name: "",
    birthdate: "",
    motivation: "",
    category: "",
    level: 1,
    exerciseTime: 0,
  };
}

function initializeStore(initialData = null) {
  const _store = store ?? new Store();

  // Create the store once in the client
  if (!store) store = _store;

  return _store;
}

export function useStore(initialState) {
  const store = useMemo(() => initializeStore(initialState), [initialState]);
  return store;
}
