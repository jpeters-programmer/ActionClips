import Axios from 'axios'

const initState = () => ({
  maneuvers: []
})

export const state = initState

export const mutations = {
  setManeuvers (state, { maneuvers }) {
    state.maneuvers = maneuvers ?? []
  },
  addManeuver (state, { maneuver }) {
    state.maneuvers.push(maneuver)
  },
  reset (state) {
    Object.assign(state, initState())
  }
}

export const actions = {
  async fetchManeuvers ({ commit }) {
    const maneuvers = (await Axios.get('http://localhost:5000/api/maneuvers')).data
    commit('setManeuvers', { maneuvers })
  },
  async createManeuver ({ commit }, { maneuver }) {
    await Axios.post('http://localhost:5000/api/maneuvers', maneuver)
    commit('addManeuver', { maneuver })
  }
}
