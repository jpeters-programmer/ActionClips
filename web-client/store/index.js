import Axios from 'axios'

const initState = () => ({
  message: 'init'
})

export const state = initState

export const mutations = {
  setMessage (state, message) {
    state.message = message
  },
  reset (state) {
    Object.assign(state, initState())
  }
}

export const actions = {
  async fetchMessage ({ commit, dispatch }) {
    const message = (await Axios.get('http://localhost:5000/api/home')).data
    commit('setMessage', message)
    await dispatch('maneuvers/fetchManeuvers')
  }
}
